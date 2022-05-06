using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Classes
{
    enum Reason
    {
        ElaninMuddeti
    }

    class ErrorException : Exception
    {
        public Reason sebeb { get; set; }

        public ErrorException(string message, Reason reason) : base(message)
        {
            this.sebeb = reason;
        }
    }
}