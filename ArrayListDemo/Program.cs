using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlist= new ArrayList();
                arrlist.Add(1);
                arrlist.Add(2);
                arrlist.Add(3);
                arrlist.Add(4);
                arrlist.Add(5);

            foreach (var item in arrlist) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");

            arrlist.Insert(2, 15); //insert element at particular index
            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");

            arrlist.Sort(); //sort arraylist in acs order
            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------");

            arrlist.Reverse(); //reverse the arraylist
            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------");

            arrlist.RemoveAt(0); //remove element at particular index
            arrlist.Remove(3);//remove matching element from list
            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------");

            //arrlist.Clear(); //remove all object
            Console.WriteLine("Total element=" + arrlist.Count);
            Console.WriteLine("Capacity of Arraylist=" + arrlist.Capacity);



        }
    }
}
