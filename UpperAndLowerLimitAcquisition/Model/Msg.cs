using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerLimitAcquisition.Model
{
    public class Msg
    {
        public string category;
        public int index;
        public string str = string.Empty;
        
        public Msg(string Cg, int i, string msg)
        {
            category = Cg;
            index = i;
            str = msg;
        }
    }
}
