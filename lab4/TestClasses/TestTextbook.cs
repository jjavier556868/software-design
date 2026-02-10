using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.TestClasses
{
    [TestClass]
    public class TestTextbook
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTextbookCreation()
        {
            Textbook textbook = new Textbook
            {
                Title = "Invalid Textbook",
                Author = "John Doe",
                Subject = ""
            };
        }
    }
}
