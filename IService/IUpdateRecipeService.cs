using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acquisition.Common;

namespace Acquisition.IService
{
    public interface IUpdateRecipeService
    {
        Task<bool> UpDateRecipeUpAndLowLimitAsync(string stationNumber, List<MeasurementData> measurementDatas, out string message);
    }
}
