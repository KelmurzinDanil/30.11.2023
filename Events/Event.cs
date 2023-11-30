using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Events
{
    internal class Event
    {
        private string eventDate;
        private string eventDescription;
        private int numberOfEvent;
        private int numberOfParticipants;
        private List<Student> students = new List<Student>();
        public string EventDate { get { return this.eventDate; } }
        public string EventDiscription { get { return this.eventDescription; } }
        public int NumberOfEvent { get { return this.numberOfEvent; } }
        public int NumberOfParticipants { get { return this.numberOfParticipants; } }

        public Event(string eventDate, string eventDescription, int numberOfEvent, int numberOfParticipants)
        {
            this.eventDate = eventDate;
            this.eventDescription = eventDescription;
            this.numberOfEvent = numberOfEvent;
            this.numberOfParticipants = numberOfParticipants;
        }
        public void AddEventInFile(string path)
        {
            File.AppendAllText(path, $"Мероприятие '{eventDescription}' на {eventDate}. От каждой группы " +
                                                 $"нужно {numberOfParticipants} человек. \n");

        }
        public Student PullStudent(string path, int i) // Вытаскиваем студентов из файла и создаем экземпляры класса Student 
        {
            string s = File.ReadLines(path).Skip(i).First();
            string numberGroup = string.Concat(s.Where(Char.IsDigit));
            return new Student(s, numberGroup, RandomNumberOfParticipantsInEvents());
        }
        public int RandomNumberOfParticipantsInEvents()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2); ;
        }
        public void CreateEvent(string path) // Создания файла мероприятия
        {
            File.WriteAllText(path, $"Мероприятие - {eventDescription}  , Кол-во участников - {numberOfParticipants} ");
        }
        public void RegistrationFreeloaders(string path, Student student) // Запись халявщиков
        {
            if (student.SendForceForEvent(numberOfEvent))
            {
                students.Add(student);
                File.AppendAllText(path, $"\n{student.Name} {student.Group}");
            }
        }
        public void RegistrationStudent(string path, Student student) // Запись студентов
        {
            if (students.Count < numberOfParticipants && student.SendAtWillForEvent(student))
            {
                File.AppendAllText(path, $"\n{student.Name} {student.Group}");
            }
        }
        public void RegistrationAllEvent(string path1, string path2) // Запись всех мероприятий в один файл
        {
            File.AppendAllText($@"d:\{path1}.txt", File.ReadAllText($@"d:\{path2}.txt"));
        }
    }
}
