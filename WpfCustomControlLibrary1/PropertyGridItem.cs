using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid
{
    public class PropertyGridItem
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public PropertyGridItem(string propertyName, object propertyValue)
        {
            Name = propertyName;
            Value = propertyValue;
        }
    }
}
