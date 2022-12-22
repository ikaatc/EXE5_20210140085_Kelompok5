using System;
using System.Collections.Generic;
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
