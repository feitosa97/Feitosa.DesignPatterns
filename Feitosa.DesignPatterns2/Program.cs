using Feitosa.DesignPatterns2.Visitor;
using Feitosa.DesignPatterns2.Contract;
using Feitosa.DesignPatterns2.Expression;
using Feitosa.DesignPatterns2.Factories;
using Feitosa.DesignPatterns2.Notes;
using System;
using System.Collections.Generic;
using System.Data;
using Feitosa.DesignPatterns2.Bridge;
using Feitosa.DesignPatterns2.Command;
using Feitosa.DesignPatterns2.Adapter;
using System.Xml.Serialization;
using System.IO;

namespace Feitosa.DesignPatterns2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton();
        }
        
        public static void Singleton()
        {
            s
        }

        public static void Adapter()
        {
            var customer = new Customer();

            customer.Name = "Lucas";
            customer.Address = "Av Paulista";
            customer.BirthDate = DateTime.Now; 

            var xml = new XmlGenerator().Generate(customer);

            Console.WriteLine(xml);
        }

        public static void Command() { 
            var queue = new WorkQueue();
            var order1 = new Order("Lucas", 100d);
            var order2 = new Order("Feitosa", 200d);

            queue.Add(new PayOrderCommand(order1));
            queue.Add(new PayOrderCommand(order2));
            queue.Add(new FinishOrderCommand(order1));

            queue.Proccess();
        }

        public static void Bridge() 
        { 
            var message = new MessageAdmin("Lucas");
            message.Sender = new SmsSender();
            message.Send();
        }

        public static void Visitor()
        { 
            var left = new Sum(new Sum(new Number(1), new Number(100)), new Number(10));
            var right = new Substract(new Number(20), new Number(10));
            var sum = new Sum(left, right);

            PrinterVisitor printer = new PrinterVisitor();
            sum.Accept(printer); 
        }


        public static void Interpreter()
        { 
            var left = new Sum(new Sum(new Number(1), new Number(100)), new Number(10));
            var right = new Substract(new Number(20), new Number(10));
            var sum = new Sum(left, right);

            Console.WriteLine(sum.Calculate());
        }
        
        public static void Memento() 
        { 

            var history = new History();
            var contract = new Contract.Contract(DateTime.Now, "Lucas", ContractType.New);

            history.Add(contract.Save());

            contract.Next();
            history.Add(contract.Save());

            contract.Next();
            history.Add(contract.Save());

            Console.Write(contract.Type);
            Console.Write(history.Get(2).Contract.Type);
        }

        public static void Music()
        {
            var notes = new MusicalNote();

            var music = new List<INote>()
            {
                notes.Get("do"),
                notes.Get("re"),
                notes.Get("mi"),
                notes.Get("fa"),
                notes.Get("fa"),
                notes.Get("fa")
            };

            var piano = new Piano();

            piano.Beep(music);

        }
    }
}
