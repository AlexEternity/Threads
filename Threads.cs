using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab4
{
    public class Token
    {
        public int Recipient { get; set; }
        public string Data { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[main]Give first message...");
            Thread thread = new Thread(() => { Threading(1, new Token() { Recipient = 100, Data = "token" }); });
            thread.Start();
        }

        static void Threading(int i, Token t)
        {
            if (t.Recipient == i)
            {
                Console.WriteLine("Take last message....");
                Console.WriteLine(t.Data + " (" + i + ")");
                Console.Read();
            }
            else
            {
                Console.WriteLine(i);
                Console.WriteLine("Took message...Give next");
                Thread thread = new Thread(() => Threading(i + 1, t));
                thread.Start();
            }
        }
    }
}