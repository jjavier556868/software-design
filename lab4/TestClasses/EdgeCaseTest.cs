using lab4.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.TestClasses
{
    [TestClass]
    public class EdgeCaseTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyTitleBookCreation() {
            
            Book book = new Book { Title = "", Author = "John Smith" };

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidMagazineCreation()
        {
            Magazine magazine = new Magazine
            {
                Title = "Invalid",
                Author = "Jane Doe",
                IssueNumber = -1
            };

        }
    }
}
