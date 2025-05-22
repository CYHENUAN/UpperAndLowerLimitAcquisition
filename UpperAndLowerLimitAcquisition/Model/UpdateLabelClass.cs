using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class UpdateLabelClass
    {
        public Label? LblTotal { get; private set; }
        public Label? LabelSucess { get; private set; }
        public Label? LabelFailed { get; private set; }

        public UpdateLabelClass(Label labeltotal, Label labelsucess, Label labelfailed)
        {
            LblTotal = labeltotal;
            LabelSucess = labelsucess;
            LabelFailed = labelfailed;
        }
    }
}
