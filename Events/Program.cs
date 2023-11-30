using System;
using System.IO;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathStud = "Студенты.txt";
            string pathEvent = "Мероприятие.txt";
            int numberOfEvent = 4;
            Event _event = new Event("23.04.24", "Красить кнопки", numberOfEvent, 9);

            Student st1 = _event.PullStudent(pathStud, 0);
            Student st2 = _event.PullStudent(pathStud, 1);
            Student st3 = _event.PullStudent(pathStud, 2);
            Student st4 = _event.PullStudent(pathStud, 3);
            Student st5 = _event.PullStudent(pathStud, 4);
            Student st6 = _event.PullStudent(pathStud, 5);
            Student st7 = _event.PullStudent(pathStud, 6);
            Student st8 = _event.PullStudent(pathStud, 7);
            Student st9 = _event.PullStudent(pathStud, 8);
            Student st10 = _event.PullStudent(pathStud, 9);
            Student st11 = _event.PullStudent(pathStud, 10);
            Student st12 = _event.PullStudent(pathStud, 11);

            _event.CreateEvent(pathEvent);

            _event.RegistrationFreeloaders(pathEvent, st1);
            _event.RegistrationFreeloaders(pathEvent, st2);
            _event.RegistrationFreeloaders(pathEvent, st3);
            _event.RegistrationFreeloaders(pathEvent, st4);
            _event.RegistrationFreeloaders(pathEvent, st5);
            _event.RegistrationFreeloaders(pathEvent, st6);
            _event.RegistrationFreeloaders(pathEvent, st7);
            _event.RegistrationFreeloaders(pathEvent, st8);
            _event.RegistrationFreeloaders(pathEvent, st9);
            _event.RegistrationFreeloaders(pathEvent, st10);
            _event.RegistrationFreeloaders(pathEvent, st11);
            _event.RegistrationFreeloaders(pathEvent, st12);

            _event.RegistrationStudent(pathEvent, st1);
            _event.RegistrationStudent(pathEvent, st2);
            _event.RegistrationStudent(pathEvent, st3);
            _event.RegistrationStudent(pathEvent, st4);
            _event.RegistrationStudent(pathEvent, st5);
            _event.RegistrationStudent(pathEvent, st6);
            _event.RegistrationStudent(pathEvent, st7);
            _event.RegistrationStudent(pathEvent, st8);
            _event.RegistrationStudent(pathEvent, st9);
            _event.RegistrationStudent(pathEvent, st10);
            _event.RegistrationStudent(pathEvent, st11);
            _event.RegistrationStudent(pathEvent, st12);

            string fileText = File.ReadAllText(pathEvent);
            Console.WriteLine(fileText);


            Console.ReadKey();
        }
    }
}
