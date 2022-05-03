using System.Windows;
using DevExpress.Xpf.Editors.Validation;
using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.Spin
{
    public class SsSpinEdit : DevExpress.Xpf.Editors.SpinEdit
    {
        public SsSpinEdit()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(0);
            InvalidValueBehavior = InvalidValueBehavior.AllowLeaveEditor;
            ControlWidthType = ControlWidthType.Normal;
            SetControlWidthType();
        }


        public ControlWidthType ControlWidthType
        {
            get => (ControlWidthType)GetValue(ControlWidthTypeProperty);
            set => SetValue(ControlWidthTypeProperty, value);
        }

        public static readonly DependencyProperty ControlWidthTypeProperty =
            DependencyProperty.Register("ControlWidthType", typeof(ControlWidthType),
                typeof(SsSpinEdit), new PropertyMetadata(ControlWidthType.Normal, ControlWidthTypeChangedCallback));

        private static void ControlWidthTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((SsSpinEdit)d).SetControlWidthType();
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