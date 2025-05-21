using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class AcquisitionLogNotification: INotification
    {
        public EquipmentType EquipmentTypeInfo { get; set; }
        public LogLevel logLevel { get; set; }
        public string? Message { get; set; }
    }
}
