namespace SecurityStudio.Base.Control.Spin
{
    public class SsDoubleSpinEdit : SsSpinEdit
    {
        public SsDoubleSpinEdit()
        {
            IsFloatValue = true;
            EditValueType = typeof(double);
        }
    }
}