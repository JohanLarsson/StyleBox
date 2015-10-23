namespace StyleBox.Controls
{
    using System.ComponentModel;
    using System.Windows;

    public static class DesignTime
    {
        private static readonly DependencyObject DependencyObject = new DependencyObject();

        public static bool IsDesignTime => DesignerProperties.GetIsInDesignMode(DependencyObject);
    }
}
