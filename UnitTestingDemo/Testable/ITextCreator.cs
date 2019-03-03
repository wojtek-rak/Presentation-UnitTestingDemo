using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingDemo.Testable
{
    public interface ITextCreator
    {
        void AddTitle(string title);
        void AddDescription(string description);
        string ExportText();
    }
}
