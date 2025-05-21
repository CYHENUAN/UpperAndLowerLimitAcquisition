using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpperAndLowerLimitAcquisition.Helper;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            //如果打标配置文件路径为空，则使用默认路径           
            this.propertyGrid1.SelectedObject = GlobalData.Params;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializeHelper<ParamsSetting>.SerializeToFile(GlobalData.ParamsSettingPath, propertyGrid1.SelectedObject as ParamsSetting);
            this.Close();
        }
    }
}
