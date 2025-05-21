using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperAndLowerLimitAcquisition.Model;

namespace UpperAndLowerLimitAcquisition.Controls
{
    public class EquipmentCollectionEditor : CollectionEditor
    {
        public EquipmentCollectionEditor(Type type) : base(type) { }

        protected override Type CreateCollectionItemType()
        {
            return typeof(CollectionClass);
        }
        protected override string GetDisplayText(object value)
        {
            if (value is CollectionClass col)
                return col.StationName ?? "（未命名）";
            return base.GetDisplayText(value);
        }

    }
}
