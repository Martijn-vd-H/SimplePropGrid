using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyGrid;

namespace PropertyGridTest
{
    public class ViewModel
    {
        public List<PropertyGroup> Groups { get; set; }

        public ViewModel()
        {
            Groups = new List<PropertyGroup>();

            PropertyGroup group1 = new PropertyGroup();
            group1.Name = "Group1";
            group1.Items.Add(new PropertyGridItem("Item1", "test"));
            group1.Items.Add(new PropertyGridItem("Item2", 300));
            group1.Items.Add(new PropertyGridItem("Item3", true));
            group1.Items.Add(new PropertyGridItem("Item4", 5.2));
            Groups.Add(group1);

            PropertyGroup group2 = new PropertyGroup();
            group2.Name = "Group2";
            group2.Items.Add(new PropertyGridItem("Item1", "test"));
            group2.Items.Add(new PropertyGridItem("Item2", 300));
            group2.Items.Add(new PropertyGridItem("Item3", true));
            group2.Items.Add(new PropertyGridItem("Item4", 5.2));
            Groups.Add(group2);
        }
    }
}
