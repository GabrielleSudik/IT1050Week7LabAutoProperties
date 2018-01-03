using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LabAutoProperties
{
    /* Create an application that does the following. Submit the complete application:

        Create a class of your choosing DONE
        In that class, create three auto properties DONE
        In your Main() method, create an instance of the class DONE 
        On that instance, set values to each property DONE
        Show values of each property to the user DONE */

    class Books
    {
        //PROPERTIES (fields aren't needed because we won't be changing anything)
            //properties are enough.

        public string Title { get; set; }
        public string Author { get; set; }
        public string Cover { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Books sciFi = new Books();

            sciFi.Title = "2001";
            sciFi.Author = "Arthur C. Clarke";
            sciFi.Cover = "hardback";

            Console.WriteLine($"{sciFi.Author}'s {sciFi.Title} (in {sciFi.Cover}), is very overrated." +
                $"\n\tI know, I know... heresy.");
            Console.ReadLine();
        }
    }
}
