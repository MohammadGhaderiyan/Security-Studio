using System.Windows;
using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsComboBoxGridColumn : SsGridColumn
    {
        public SsComboBoxGridColumn()
        {
            EditSettings = new ComboBoxEditSettings
            {
                ValidateOnTextInput = false,
                IncrementalFiltering = true,
            };
        }


        public object ItemsSource
        {
            get => (object)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(object),
                typeof(SsComboBoxGridColumn), new PropertyMetadata(null, ItemsSourceChangedCallback));

        private static void ItemsSourceChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var ssComboBoxGridColumn = (SsComboBoxGridColumn)d;
                var comboBoxEditSettings = (ComboBoxEditSettings)ssComboBoxGridColumn.EditSettings;
                comboBoxEditSettings.ItemsSource = e.NewValue;
            }
        }


        public string DisplayMember
        {
            get => (string)GetValue(DisplayMemberProperty);
            set => SetValue(DisplayMemberProperty, value);
        }

        public static readonly DependencyProperty DisplayMemberProperty =
            DependencyProperty.Register("DisplayMember", typeof(string),
                typeof(SsComboBoxGridColumn), new PropertyMetadata(null, DisplayMemberChangedCallback));

        private static void DisplayMemberChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var ssComboBoxGridColumn = (SsComboBoxGridColumn)d;
                var comboBoxEditSettings = (ComboBoxEditSettings)ssComboBoxGridColumn.EditSettings;
                comboBoxEditSettings.DisplayMember = e.NewValue.ToString();
            }
        }


        public string ValueMember
        {
            get => (string)GetValue(ValueMemberProperty);
            set => SetValue(ValueMemberProperty, value);
        }

        public static readonly DependencyProperty ValueMemberProperty =
            DependencyProperty.Register("ValueMember", typeof(string),
                typeof(SsComboBoxGridColumn), new PropertyMetadata(null, ValueMemberChangedCallback));

        private static void ValueMemberChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var ssComboBoxGridColumn = (SsComboBoxGridColumn)d;
                var comboBoxEditSettings = (ComboBoxEditSettings)ssComboBoxGridColumn.EditSettings;
                comboBoxEditSettings.ValueMember = e.NewValue.ToString();
            }
        }
    }
}