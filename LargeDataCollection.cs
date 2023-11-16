using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    public class LargeDataCollection: IDisposable

    {
        private bool disposed = false;
        private int[] data;

        public LargeDataCollection(int[] initialData)
        {
            data = initialData;
        }

        public void AddElement(int element)
        {
          
            if (data == null)
            {
                data = new int[] { element };
            }
            else
            {
           
                int[] newData = new int[data.Length + 1];

              
                Array.Copy(data, newData, data.Length);

            
                newData[data.Length] = element;

            
                data = newData;

                Console.WriteLine("element added successfully");
            }

        }

        public void RemoveElement(int element)
        {
           
            if (data == null || data.Length == 0)
            {
              
                Console.WriteLine("Collection is empty. No elements to remove.");
                return;
            }

         
            int index = Array.IndexOf(data, element);

            if (index == -1)
            {
                
                Console.WriteLine($"Element {element} not found in the collection.");
                return;
            }

        
            int[] newData = new int[data.Length - 1];

            Array.Copy(data, 0, newData, 0, index);

            Array.Copy(data, index + 1, newData, index, data.Length - index - 1);

            data = newData;
            Console.WriteLine("element removed");

        }

        public int AccessElement(int index)
        {
           
            if (data == null || index < 0 || index >= data.Length)
            {
                
                Console.WriteLine("Index is out of bounds or collection is empty.");
                return -1; 
            }

            return data[index];
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                    data = null;
                }

                disposed = true;
            }
        }

      
        ~LargeDataCollection()
        {
            Dispose(false);
        }

    }
}
