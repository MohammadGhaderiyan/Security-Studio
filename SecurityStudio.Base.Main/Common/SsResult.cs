using System;

namespace SecurityStudio.Base.Main.Common
{
    public class SsResult
    {
        public bool IsSuccessful { get; set; }
        public Exception Exception { get; set; }

        public SsResult()
        {
            IsSuccessful = true;
        }

        public SsResult(Exception exception)
        {
            IsSuccessful = false;
            Exception = exception;
        }
    }

    public class SsResult<T> : SsResult
    {
        public T Value { get; set; }

        public SsResult(T value)
        {
            Value = value;
        }

        public SsResult(Exception exception) : base(exception)
        {
        }
    }
}