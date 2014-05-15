using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace PropGridTest
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
