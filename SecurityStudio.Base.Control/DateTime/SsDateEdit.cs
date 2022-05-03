using System.Windows;
using DevExpress.Xpf.Editors;
using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.DateTime
{
    public class SsDateEdit : DateEdit
    {
        public SsDateEdit()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            ControlWidthType = ControlWidthType.Normal;
            Margin = new Thickness(0);
            SizeChanged += OnSizeChanged;
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
                typeof(SsDateEdit), new PropertyMetadata(ControlWidthType.Normal, ControlWidthTypeChangedCallback));

        private static void ControlWidthTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((SsDateEdit)d).SetControlWidthType();
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