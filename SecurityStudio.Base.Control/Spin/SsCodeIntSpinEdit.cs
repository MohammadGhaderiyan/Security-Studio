namespace SecurityStudio.Base.Control.Spin
{
    public class SsCodeIntSpinEdit : SsIntSpinEdit
    {
        public SsCodeIntSpinEdit()
        {
            AllowNullInput = true;
            MinValue = 1;
        }
    }
}