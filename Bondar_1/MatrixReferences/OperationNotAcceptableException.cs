using System;

namespace MatrixReferences
{
    class OperationNotAcceptableException : Exception
    {
        public OperationNotAcceptableException(String message) : base(message)
        { }
    }
}
