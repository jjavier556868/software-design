using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Classes
{
    public class Magazine : Book
    {
        private int _issueNum;
        public int IssueNumber
        {
            get { return _issueNum; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Issue number cannot be negative.");
                else _issueNum = value;
            }
        }
        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber}";
        }

    }
        
    
}

