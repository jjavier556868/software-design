using lab4.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Textbook:Book
    {
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Subject cannot be empty.");
                else _subject = value;
            }
        }
    }
}
