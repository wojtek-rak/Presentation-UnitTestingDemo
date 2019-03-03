using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnitTestingDemo.CloseToBeTestable;

namespace UnitTestingDemo.Tests.CloseToBeTestable
{
    [TestFixture]  
    public class FileCreatorCloseTests
    {
        [Test]
        public void CreateText_NotEmptyTitle_ProperAddLine()
        {
            var fileCreator = new FileCreatorClose();

            var title = "Title";
            var desc = "Desc";
            var result = fileCreator.CreateText(title, desc);
            var expected = $"{title}\r\n{desc}\r\n";

            Assert.AreEqual(expected, result);

            //Is it completely correct?
        }

        [Test]
        public void CreateText_EmptyTitle_ThrowException()
        {
            var fileCreator = new FileCreatorClose();

            var title = "";
            var desc = "Desc";

            Assert.Throws<EmptyTitleException>(() => fileCreator.CreateText(title, desc));
        }
    }
}
