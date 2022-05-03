using DevExpress.Xpf.Bars;

namespace SecurityStudio.Base.Control.Bar
{
    public class SsContentAndGlyphBarButtonItem : SsBarButtonItem
    {
        public SsContentAndGlyphBarButtonItem()
        {
            BarItemDisplayMode = BarItemDisplayMode.ContentAndGlyph;
            GlyphAlignment = System.Windows.Controls.Dock.Top;
        }
    }
}