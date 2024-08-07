using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task3.part_01.Question_2
{
    //a.Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
    public delegate string GetPropDelegate(Book b);
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString("F2");
        }
    }

}
