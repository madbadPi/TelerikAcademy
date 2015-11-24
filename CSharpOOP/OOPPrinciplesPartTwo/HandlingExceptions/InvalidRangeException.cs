namespace HandlingExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        private T end;

        public InvalidRangeException(string msg, T rangeStart, T rangeEnd)
            : base(msg)
        {
            this.Start = rangeStart;
            this.End = rangeEnd;
        }

        public T Start { get; set; }

        public T End
        {
            get
            {
                return this.end;
            }

            set
            {
                if (value.CompareTo(this.Start) < 0)
                {
                    throw new ArgumentOutOfRangeException("The end of the range can't be before the start.");
                }
                this.end = value;
            }
        }
    }
}
