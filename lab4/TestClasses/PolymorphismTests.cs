using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using lab4.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4.TestClasses
{
    [TestClass]
    public class PolymorphismTests
    {

        [TestMethod]
        public void TestPolymorphism_GetInfo_Method() {
            Book[] books = new Book[] {
                new Book { Title = "Generic Book", Author = "John Smith" },
                new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMB = 5 },
                new Textbook { Title = "Programming 101", Author = "Dr. Alan Turing", Subject = "Programming" }
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());

        }

    }



}

