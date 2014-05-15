using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PropertyGrid
{
    public class PropertyGrid : ItemsControl
    {
        public Brush GridColor
        {
            get { return (Brush)GetValue(GridColorProperty); }
            set { SetValue(GridColorProperty, value); }
        }

        public static readonly DependencyProperty GridColorProperty =
            DependencyProperty.Register("GridColor", typeof(Brush), typeof(PropertyGrid), new UIPropertyMetadata(new SolidColorBrush(Colors.Transparent)));

        static PropertyGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PropertyGrid), new FrameworkPropertyMetadata(typeof(PropertyGrid)));
        }
    }
}
