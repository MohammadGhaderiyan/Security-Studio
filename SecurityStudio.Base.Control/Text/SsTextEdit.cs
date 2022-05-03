using System;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Editors.Validation;
using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.Text
{
    public class SsTextEdit : DevExpress.Xpf.Editors.TextEdit
    {
        public SsTextEdit()
        {
            VerticalAlignment = VerticalAlignment.Top;
            HorizontalAlignment = HorizontalAlignment.Left;
            Margin = new Thickness(0);
            InvalidValueBehavior = InvalidValueBehavior.AllowLeaveEditor;
            ControlWidthType = ControlWidthType.Normal;
            SizeChanged += OnSizeChanged;
            KeyDown += OnKeyDown;
            SetControlWidthType();
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ControlWidthType == ControlWidthType.Auto)
                Width = e.NewSize.Width;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (EditValue == null) EditValue = "";
                EditValue += new Random().Next(10000, 99999).ToString();
            }
        }


        public ControlWidthType ControlWidthType
        {
            get => (ControlWidthType)GetValue(ControlWidthTypeProperty);
            set => SetValue(ControlWidthTypeProperty, value);
        }

        public static readonly DependencyProperty ControlWidthTypeProperty =
            DependencyProperty.Register("ControlWidthType", typeof(ControlWidthType),
                typeof(SsTextEdit), new PropertyMetadata(ControlWidthType.Normal, ControlWidthTypeChangedCallback));

        private static void ControlWidthTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((SsTextEdit)d).SetControlWidthType();
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