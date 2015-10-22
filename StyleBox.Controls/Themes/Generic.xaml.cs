namespace StyleBox.Controls.Themes
{
    using System;
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Reflection;
    using System.Windows;

    public partial class Generic : ResourceDictionary
    {
        public Generic()
        {
            //if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            //{
            //    var fieldInfo = typeof(ResourceDictionary).GetField("_mergedDictionaries", BindingFlags.Instance | BindingFlags.NonPublic);
            //    fieldInfo.SetValue(this, new DesignTimeMerged(this));
            //}
        }

        private class DesignTimeMerged : ObservableCollection<ResourceDictionary>
        {
            private readonly Generic _generic;

            public DesignTimeMerged(Generic generic)
            {
                _generic = generic;
            }

            protected override void ClearItems()
            {
                throw new NotSupportedException();
            }

            protected override void InsertItem(int index, ResourceDictionary item)
            {
                //Debugger.Break();
                foreach (DictionaryEntry kvp in item)
                {
                    _generic.Add(kvp.Key, kvp.Value);
                }
                foreach (var merged in item.MergedDictionaries)
                {
                    InsertItem(_generic.Count, merged);
                }
            }

            protected override void RemoveItem(int index)
            {
                throw new NotSupportedException();
            }

            protected override void SetItem(int index, ResourceDictionary item)
            {
                throw new NotSupportedException();
            }
        }
    }
}
