using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_20210140085_Kelompok5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class Queue
    {
        Node ika, tania;
        public Queue()
        {
            ika = null;
            tania = null;
        }
        public void Insert()
        {
            string nm;
            Node newnode = new Node();
            Console.WriteLine("Masukkan Element: ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (ika == null)
            {
                ika = newnode;
                tania = newnode;
                return;
            }
            tania.next = newnode;
            tania = newnode;
        }
        public void Delete()
        {
            if (ika == null)
            {
                Console.WriteLine("Queue is Empty!");
                return;
            }
            ika = ika.next;
            if (ika == null)
                tania = null;
        }
        public void Display()
        {
            if (ika == null)
            {
                Console.WriteLine("Queue is Empty!");
                return;
            }
            Node Display;
            for (Display = ika; Display != null; Display = Display.next)
                Console.WriteLine(Display.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter you choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                q.Insert();
                            }
                            break;
                        case '2':
                            {
                                q.Delete();
                            }
                            break;
                        case '3':
                            {
                                q.Display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                { }
            }
        }
    }
}
