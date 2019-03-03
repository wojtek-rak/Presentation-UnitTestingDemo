using System;
using UnitTestingDemo.CloseToBeTestable;
using UnitTestingDemo.Testable;
using UnitTestingDemo.Untestable;

namespace UnitTestingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Untestable
            //var creator = new TextCreatorUntestable();
            //creator.CreateText("title", "desc");

            //CloseToBeTestable
            //var creator = new FileCreatorClose();
            //var text = creator.CreateText("title", "desc");
            //creator.SaveFile(text);

            //CloseToBeTestable
            //var textCreator = new TextCreator();
            //var creator = new FileCreator(textCreator);
            //var text = creator.CreateText("title", "desc");
            //creator.SaveFile(text);
        }
    }
}
