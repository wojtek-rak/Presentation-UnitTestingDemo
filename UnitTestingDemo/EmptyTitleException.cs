using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingDemo
{
    public class EmptyTitleException : Exception
    {
        public EmptyTitleException()
        {
        }

        public EmptyTitleException(string message)
            : base(message)
        {
        }

        public EmptyTitleException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
