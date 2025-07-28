using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Common.Exceptions
{
    public abstract  class AppException : Exception
    {
        public virtual int StatusCode { get; } = 500;

        protected AppException(string message) : base(message) { }
    }
}
