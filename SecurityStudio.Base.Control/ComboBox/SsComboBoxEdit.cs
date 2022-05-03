using System.Windows;
using DevExpress.Xpf.Editors;
using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.ComboBox
{
    public class SsComboBoxEdit : ComboBoxEdit
    {
        public SsComboBoxEdit()
        {
            StyleSettings = new ComboBoxStyleSettings();
            VerticalAlignment = VerticalAlignment.Center;
            HorizontalAlignment = HorizontalAlignment.Left;
            ControlWidthType = ControlWidthType.Normal;
            IsTextEditable = true;
            ValidateOnTextInput = false;
            IncrementalFiltering = true;
            NullValueButtonPlacement = EditorPlacement.EditBox;
            ShowNullValueButtonOnFocusOnly = true;
            SizeChanged += OnSizeChanged;
            Margin = new Thickness(0);
            SetControlWidthType();
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ControlWidthType == ControlWidthType.Auto)
                Width = e.NewSize.Width;
        }


        public ControlWidthType ControlWidthType
        {
            get => (ControlWidthType)GetValue(ControlWidthTypeProperty);
            set => SetValue(ControlWidthTypeProperty, value);
        }

        public static readonly DependencyProperty ControlWidthTypeProperty =
            DependencyProperty.Register("ControlWidthType", typeof(ControlWidthType),
                typeof(SsComboBoxEdit), new PropertyMetadata(ControlWidthType.Normal, ControlWidthTypeChangedCallback));

        private static void ControlWidthTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((SsComboBoxEdit)d).SetControlWidthType();
        }

        private void SetControlWidthType()
        {
            if (ControlWidthType != ControlWidthType.Auto)
                Width = (double)ControlWidthType;
            else
            {
                Width = double.NaN;
                VerticalAlignment = VerticalAlignment.Stretch;
                HorizontalAlignment = HorizontalAlignment.Stretch;
            }
        }
    }
}