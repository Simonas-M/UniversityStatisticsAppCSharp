using System;
using System.Runtime.Serialization;

namespace UniversitySQL
{
    [Serializable]
    internal class DateOutOfRangeException : Exception
    {
        private DateTime _time;

        public DateTime Time
        {
            get
            {
                return _time;
            }
        }

        public DateOutOfRangeException()
        {
        }

        public DateOutOfRangeException(DateTime time)
        {
            _time = time;
        }

        public DateOutOfRangeException(DateTime time, string message) : base(message)
        {
            _time = time;
        }

        public DateOutOfRangeException(string message) : base(message)
        {
        }

        public DateOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}