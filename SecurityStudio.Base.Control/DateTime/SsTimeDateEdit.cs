namespace SecurityStudio.Base.Control.DateTime
{
    public class SsTimeDateEdit : SsDateEdit
    {
        public SsTimeDateEdit()
        {
            Mask = "T";
            MaskUseAsDisplayFormat = true;
        }
    }
}