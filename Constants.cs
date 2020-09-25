using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class Constants
    {

        public void Input() {

            Console.WriteLine("Enter the scrambled word(s) manually or as file: F - file / M - manual: ");
            
        }

        public void File()
        {
            Console.Write("Enter the full path including the file name: ");
        }

        public void Mannual()
        {
            Console.Write("Enter the words mannually ( seperated by commas if multiple ) ");
        }

        public void Again()
        {
            Console.WriteLine("Would you like to continue? Y/N");
        }

    }
    

   

}
