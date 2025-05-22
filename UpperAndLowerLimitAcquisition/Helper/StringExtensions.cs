using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.Helper
{
    public static class StringExtensions
    {
        public static bool IsDateTime(this string val)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                return false;
            }

            DateTime result;
            return DateTime.TryParse(val, out result);
        }
    }
}
