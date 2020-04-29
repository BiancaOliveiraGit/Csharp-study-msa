using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
   // public class DelegateExample
   // {
        public delegate void AddBookcallback(int i);

        public class BookTracker
        {
            public List<Book> books = new List<Book>();

            public void Addbook(string name, AddBookcallback callback)
            {
                books.Add(new Book(name));
                callback(books.Count);
            }
        }

        public class Runner
        {
            BookTracker tracker = new BookTracker();


        public void Add(string name)
        {
            tracker.Addbook(name, delegate (int i)
              {
                  /*this is the delgate function CODE BODY 
                    books.count gets passed in thru the (int i)
                    so can processing using the books.count
                  */
                  Console.WriteLine(i);
                  Console.WriteLine(tracker.books.Count);
                      /*
                       delegate allows to pass in a function
                       by going delegate (int i) {function code in here});
                       gets the passed in parameters from callback method
                       */
              });
        }
    }

        public class Book
        {
        public string Name;
        public int Count;
        public  Book(string name)
        {
            Name = name;
        }



        }
  }
//}
