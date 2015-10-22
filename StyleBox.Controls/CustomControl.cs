using System.Windows;
using System.Windows.Controls;

namespace StyleBox.Controls
{
    public class CustomControl : Control
    {
        static CustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl), new FrameworkPropertyMetadata(typeof(CustomControl)));
        }
    }
}
