using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class PressDetailDto
    {
        public string? StationName { get; set; }
        public string? EquimentName { get; set; }
        public string? FailFileSource { get; set; }
        public Image?  Icon { get; set; }
        public AcquistionState State {  get; set; }
        
    }
}
