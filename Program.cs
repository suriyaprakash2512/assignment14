using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialData = { 1, 2, 3, 4, 5 };
            LargeDataCollection largeDataCollection = null;


            try {

                largeDataCollection = new LargeDataCollection(initialData);
            
                Console.WriteLine("Enter an element to add: ");
                int elementToAdd = int.Parse(Console.ReadLine());

                largeDataCollection.AddElement(elementToAdd);

                Console.WriteLine("Enter the index to remove: ");
                int indexToRemove = int.Parse(Console.ReadLine());
                largeDataCollection.RemoveElement(indexToRemove);

                Console.WriteLine("Enter the index to access: ");
                int indexToAccess = int.Parse(Console.ReadLine());
                int accessedElement = largeDataCollection.AccessElement(indexToAccess);

                Console.WriteLine($"Accessed Element: {accessedElement}");

            }

            finally
            {

                largeDataCollection.Dispose();
            }

           
            Console.ReadKey();
         
        }
    }
}
