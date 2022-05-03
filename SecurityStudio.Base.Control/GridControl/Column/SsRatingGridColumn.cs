using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsRatingGridColumn : SsGridColumn
    {
        public SsRatingGridColumn()
        {
            EditSettings = new RatingEditSettings();
        }
    }
}