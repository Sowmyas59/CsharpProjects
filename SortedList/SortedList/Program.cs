using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
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
            
            //string value = Convert.ToString(sl1[4]);
            //Console.WriteLine($"Value={value}");

            for (int i=0; i<sl1.Count;i++)
            {
                Console.WriteLine($"\nKey: {sl1.GetKey(i)}, Value: {sl1.GetByIndex(i)}");
                
            }
            //alternate for loop
            /* foreach(DictionaryEntry element in sl1)
             * {
             * Console.WriteLine($"Key:{element.Key},Value.{element.Value});*/


            /*SortedList sl2 = new SortedList();
            sl2.Add(3.1, "Number Three & Decimal Value 1");
            sl2.Add(1.1, "Number One & Decimal Value 1");
            sl2.Add(5.1, "Number Five & Decimal Value 1");
            sl2.Add(4.1, "Number Four & Decimal Value 1");
            sl2.Add(2.1, "Number Two & Decimal Value 1");

            for (int i = 0; i < sl2.Count; i++)
            {
                Console.WriteLine($"\nKey: {sl2.GetKey(i)}, Value: {sl2.GetByIndex(i)}");

            }*/


            /*SortedList sl3 = new SortedList();
            sl3.Add("3.1", "Number Three & Decimal Value 1");
            sl3.Add("1.1", "Number One & Decimal Value 1");
            sl3.Add("5.1", "Number Five & Decimal Value 1");
            sl3.Add("4.1", "Number Four & Decimal Value 1");
            sl3.Add("2.1", "Number Two & Decimal Value 1");

            for (int i = 0; i < sl3.Count; i++)
            {
                Console.WriteLine($"\nKey: {sl3.GetKey(i)}, Value: {sl3.GetByIndex(i)}");

            }*/
            //string str1 = Convert.ToString(obj);
            //string str2 = obj.ToString();
            //string str3 = obj as string;
            //string str4 = (string)obj;
        }
    }
}
