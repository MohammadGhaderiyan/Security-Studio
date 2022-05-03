namespace SecurityStudio.Base.Control.DateTime
{
    public class SsDateTimeDateEdit : SsDateEdit
    {
        public SsDateTimeDateEdit()
        {
            Mask = "G";
            MaskUseAsDisplayFormat = true;
        }
    }
}