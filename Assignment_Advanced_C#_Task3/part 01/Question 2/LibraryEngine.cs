using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task3.part_01.Question_2
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, /* Pointer To BookFunction */GetPropDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
