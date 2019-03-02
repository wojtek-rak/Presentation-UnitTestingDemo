using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingDemo
{
    public class TextCreator
    {
        private readonly StringBuilder _sb = new StringBuilder();

        public void AddTitle(string title)
        {
            _sb.AppendLine(title);
        }

        public void AddDescription(string description)
        {
            _sb.AppendLine(description);
        }

        public string ExportText()
        {
            var exportedText = _sb.ToString();
            _sb.Clear();
            return exportedText;
        }

        //public override string ToString()
        //{
        //    var sourceText = _sb.ToString();
        //    _sb.Clear();
        //    return sourceText;
        //}
    }
}
