using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.Common;
using Acquisition.IService;

namespace Acquisition.Service
{
    public class UpdateRecipeService : IUpdateRecipeService
    {
        public Task<bool> UpDateRecipeUpAndLowLimitAsync(string stationNumber, List<MeasurementData> measureMentDatas, out string message)
        {
            throw new NotImplementedException();
        }
    }
}
