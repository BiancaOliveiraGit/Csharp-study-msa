using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Study_Csharp
{
    public static class XElementTest
    {
        public static void SimpleXElement()
        {
            XElement contacts =
                new XElement("Contacts",
                    new XElement("Contact",
                        new XElement("Name", "Patrick Hines"),
                        new XElement("Phone", "206-555-0144"),
                        new XElement("Address",
                            new XElement("Street1", "123 Main St"),
                            new XAttribute("City", "Mercer Island"),
                            new XAttribute("State", "WA"),
                            new XElement("Postal", "68042")
                        )
                    )
                );
            Console.WriteLine(contacts);
        }

        public static void LinqXElement()
        {
            XElement srcTree = new XElement("Root",
                new XElement("Element", 1),
                new XElement("Element", 2),
                new XElement("Element", 3),
                new XElement("Element", 4),
                new XElement("Element", 5)
            );

            XElement xmlTree = new XElement("Root",
                new XElement("Child", 1),
                new XElement("Child", 2),

                from el in srcTree.Elements()
                where (int)el > 2
                select el
            );
            Console.WriteLine(xmlTree);
        }

        public static void XElementChild()
        {
            // Create a tree with a child element.  
            XElement xmlTree1 = new XElement("Root",
                new XElement("Child1", 1)
            );

            // Create an element that is not parented.  
            XElement child2 = new XElement("Child2", 2);

            // Create a tree and add Child1 and Child2 to it.  
            XElement xmlTree2 = new XElement("Root",
                xmlTree1.Element("Child1"),
                //new XElement(child2) //cloned
                child2 //attached
            );
            Console.WriteLine(xmlTree2);
            // Compare Child1 identity.  
            Console.WriteLine("Child1 was {0}",
                xmlTree1.Element("Child1") == xmlTree2.Element("Child1") ?
                "attached" : "cloned");

            // Compare Child2 identity.  
            Console.WriteLine("Child2 was {0}",
                child2 == xmlTree2.Element("Child2") ?
                "attached" : "cloned");
        }






    }
}
