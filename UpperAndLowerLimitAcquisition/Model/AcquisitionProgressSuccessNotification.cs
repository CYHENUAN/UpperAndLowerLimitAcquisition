using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class AcquisitionProgressSuccessNotification: INotification
    {   
        public string PanelId { get;} 
        public int TotalCount { get;}
        public int SuccessCount { get;}  
        public int FailedCount { get;}
        public AcquisitionProgressSuccessNotification(string panelId, int total, int sucess, int fail)
        {
            PanelId = panelId;
            TotalCount = total;
            SuccessCount = sucess;
            FailedCount = fail;
        }
    }
}
