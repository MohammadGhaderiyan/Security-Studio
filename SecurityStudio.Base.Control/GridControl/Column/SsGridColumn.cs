using System.Windows;
using DevExpress.Xpf.Grid;
using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsGridColumn : GridColumn
    {
        public SsGridColumn()
        {
            GridColumnWidthType = GridColumnWidthType.Normal;
            SetGridColumnWidth();
        }


        public GridColumnWidthType GridColumnWidthType
        {
            get => (GridColumnWidthType)GetValue(GridColumnWidthTypeProperty);
            set => SetValue(GridColumnWidthTypeProperty, value);
        }

        public static readonly DependencyProperty GridColumnWidthTypeProperty =
            DependencyProperty.Register("GridColumnWidthType", typeof(GridColumnWidthType),
                typeof(SsGridColumn), new PropertyMetadata(GridColumnWidthType.Normal, GridColumnWidthTypeChangedCallback));

        private static void GridColumnWidthTypeChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((SsGridColumn)d).SetGridColumnWidth();
        }

        private void SetGridColumnWidth()
        {
            switch (GridColumnWidthType)
            {
                case GridColumnWidthType.Auto:
                    Width = new GridColumnWidth(0, GridColumnUnitType.Auto);
                    break;
                case GridColumnWidthType.OneStar:
                case GridColumnWidthType.TwoStar:
                case GridColumnWidthType.ThreeStar:
                    Width = new GridColumnWidth((int)GridColumnWidthType, GridColumnUnitType.Star);
                    break;
                case GridColumnWidthType.XSmall:
                case GridColumnWidthType.Small:
                case GridColumnWidthType.Normal:
                case GridColumnWidthType.Large:
                case GridColumnWidthType.XLarge:
                    Width = new GridColumnWidth((int)GridColumnWidthType, GridColumnUnitType.Pixel);
                    break;
            }
        }
    }
}