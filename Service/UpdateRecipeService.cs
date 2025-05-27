using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.Common;
using Acquisition.IService;
using Acquisition.Model.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Acquisition.Service
{
    public class UpdateRecipeService : IUpdateRecipeService
    {
        private readonly IDbContextFactory<MyDbContext> _dbContextFactory;
        public UpdateRecipeService(IDbContextFactory<MyDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<(bool isSuccess, string message)> UpDateRecipeUpAndLowLimitAsync(string stationNumber, List<MeasurementData> measureMentDatas)
        {
            string message = string.Empty;
            if (string.IsNullOrEmpty(stationNumber))
            {
                message = "同步上下限数据的工位不能为空";
                return (false, message);
            }
            if (measureMentDatas.Count == 0)
            {
                message = "同步上下限数据的检测项不能为空";
                return (false, message);
            }
            using (MyDbContext db = await _dbContextFactory.CreateDbContextAsync())
            {
                try
                {
                    var recipeItems = (from A in db.Stations
                                       join B in db.Recipes on A.Id equals B.StationId
                                       join C in db.RecipeItems on B.Id equals C.RecipeId
                                       where A.StationNumber == stationNumber && C.State == 1
                                       select C
                                       ).ToList();

                    if (recipeItems.Count == 0)
                    {
                        message = $"没有找到{stationNumber}工位的检测项配置";
                        return (false, message);
                    }
                    foreach (var item in recipeItems)
                    {
                        var measurementData = measureMentDatas.FirstOrDefault(m => m.MeasurementName == item.ParameterName);
                        // 采集的数据和配置的检测项不匹配    
                        if (measurementData == null)
                        {
                            continue;
                        }
                        //判定上线限数据是否需要更新  
                        if (measurementData.MeasurementValueLSL != item.LSL)
                        {
                            item.LSL = measurementData.MeasurementValueLSL;
                            item.EditDateTime = DateTime.Now;
                        }
                        if (measurementData.MeasurementValueUSL != item.USL)
                        {
                            item.USL = measurementData.MeasurementValueUSL;
                            item.EditDateTime = DateTime.Now;
                        }
                    }
                    await db.SaveChangesAsync();
                    message = "同步上下限数据成功";
                    return (true, message);
                }
                catch(Exception ex)
                {
                    message = $"同步上下限数据失败 -> {ex.Message}";
                    return (false, message);
                }
            }
        }
    }
}
