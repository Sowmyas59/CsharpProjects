using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {

           SortedList sl1 = new SortedList();
            sl1.Add(3, "Number Three");
            sl1.Add(1, "Number One");
            sl1.Add(5, "Number Five");
            sl1.Add(4, "Number Four");
            sl1.Add(2, "Number Two");
            
            Console.WriteLine("Count:    {0}", sl1.Count);
            Console.WriteLine("Capacity: {0}", sl1.Capacity);

            //string value = Convert.ToString(sl1[4]);
            //Console.WriteLine($"Value={value}");

            for (int i=0; i<sl1.Count;i++)
            {
                Console.WriteLine($"\nKey: {sl1.GetKey(i)}, Value: {sl1.GetByIndex(i)}");
                
            }
            Console.WriteLine($"ContainsKey()-{sl1.ContainsKey(2)}");
            
            //alternate for loop
            /*foreach(DictionaryEntry element in sl1)
             * {
             * Console.WriteLine($"Key:{element.Key},Value.{element.Value});*/


            SortedList sl2 = new SortedList();
            sl2.Add(3.1, "Number Three & Decimal Value 1");
            sl2.Add(1.1, "Number One & Decimal Value 1");
            sl2.Add(5.1, "Number Five & Decimal Value 1");
            sl2.Add(4.1, "Number Four & Decimal Value 1");
            sl2.Add(2.1, "Number Two & Decimal Value 1");

            Console.WriteLine("  \nCount:    {0}", sl2.Count);
            Console.WriteLine("Capacity: {0}", sl2.Capacity);
            for (int i = 0; i < sl2.Count; i++)
            {
                Console.WriteLine($"\nKey: {sl2.GetKey(i)}, Value: {sl2.GetByIndex(i)}");

            }


            SortedList sl3 = new SortedList();
            sl3.Add("Second", "World");
            sl3.Add("Third", "!");
            sl3.Add("First", "Hello");
            Console.WriteLine("  \nCount:    {0}", sl3.Count);
            Console.WriteLine("Capacity: {0}", sl3.Capacity);

            for (int i = 0; i < sl3.Count; i++)
            {
                Console.WriteLine($"\nKey: {sl3.GetKey(i)}, Value: {sl3.GetByIndex(i)}");

            }
           
        }
    }
}
