namespace StyleBox.Controls.Themes
{
    using System.Windows;

    public partial class Generic : ResourceDictionary
    {
        public Generic()
        {
            if (DesignTime.IsDesignTime)
            {
                // Debugger.Break();
                // var currentDomain = AppDomain.CurrentDomain;
                // var entryAssembly = currentDomain.DomainManager.EntryAssembly;
                // var application = Application.Current;
                // application.Resources.MergedDictionaries.Add(this);
            }
        }
    }
}
