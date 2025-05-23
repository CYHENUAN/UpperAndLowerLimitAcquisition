using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.Common;
using Acquisition.IService;
using Acquisition.Model.MyDbContext;

namespace Acquisition.Service
{
    public class UpdateRecipeService : IUpdateRecipeService
    {
        public Task<bool> UpDateRecipeUpAndLowLimitAsync(string stationNumber, List<MeasurementData> measureMentDatas, out string message)
        {
            message = string.Empty;
            if (string.IsNullOrEmpty(stationNumber))
            {
                message = "同步上线限数据的工位不能为空";
                return Task.FromResult(false);
            }
            using (MyDbContext db = new MyDbContext())
            {
                try
                {
                    var recipeItems = (from A in db.Stations
                                       join B in db.Recipes on A.Id equals B.StationId
                                       join C in db.RecipeItems on B.Id equals C.RecipeId
                                       where A.StationNumber == stationNumber
                                       select C
                                       ).ToList();

                    if (recipeItems.Count == 0)
                    {
                        message = $"没有找到{stationNumber}工位的检测项配置";
                        return Task.FromResult(false);
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
                    db.SaveChanges();
                    message = "同步上线限数据成功";
                    return Task.FromResult(true);
                }
                catch
                {
                    message = "同步上线限数据失败";
                    return Task.FromResult(false);
                }
            }
        }
    }
}
