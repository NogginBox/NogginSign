using System;

namespace nogginsign.net.Exceptions
{
    public abstract class NogginSignException : Exception
    {
        public NogginSignException() : base() {}
        public NogginSignException(string msg) : base(msg) { }
        public NogginSignException(string msg, Exception ex) : base(msg, ex) { }
    }

    public class SignColourException : NogginSignException
    {

    }

    public class NogginSignConnectionException : NogginSignException
    {
        public NogginSignConnectionException() : base() {}

        public NogginSignConnectionException(string msg) : base(msg) {}

        public NogginSignConnectionException(string msg, Exception ex) : base(msg, ex) { }
    }
}
