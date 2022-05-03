namespace SecurityStudio.Base.Control.Spin
{
    public class SsIntSpinEdit : SsSpinEdit
    {
        public SsIntSpinEdit()
        {
            IsFloatValue = false;
            EditValueType = typeof(int);
        }
    }
}