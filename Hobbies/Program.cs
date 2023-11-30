using System;

namespace Hobbies
{
    delegate void ReactionDelegate();
  
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] events = { "Новый альбом любимого музыканта", "Новая серия любимого сериала", "Баскетбольный матч с любимой командой", "Автомат по проге" };

            Human bob = new Human("Боб", events[0], events[1]);
            Human tom = new Human("Том", events[2], events[3]);
            Human gena = new Human("Гена", events[3], events[0]);

            Human.ReactionToEvent += bob.React;
            Human.ReactionToEvent += tom.React;
            Human.ReactionToEvent += gena.React;

            Console.WriteLine("События:  \"Новый альбом любимого музыканта\", \"Новая серия любимого сериала\", \"Баскетбольный матч с любимой командой\", \"Автомат по проге\"");
            Console.WriteLine("Введите номер события:");
            string _eventNum = Console.ReadLine();
            switch (_eventNum)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Human.RaiseEvent(events, _eventNum);                   
                    break;

                default:
                    Console.WriteLine("Такого события нету");
                    break;
            }

            Console.ReadKey();
        }
    }

}
