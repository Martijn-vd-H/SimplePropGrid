using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropGridTest
{
    class PropertyGroup
    {
        public string Name { get; set; }
        public List<PropertyGridItem> Items { get; set; }

        public PropertyGroup()
        {
            Items = new List<PropertyGridItem>();
            Name = "";
        }
    }
}
