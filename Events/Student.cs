using System;

namespace Events
{
    enum StatusStudent
    {
        Go,
        NotGo
    }
    internal class Student
    {
        private string nameAndSurname;
        private int numberOfParticipantsInEvents;
        private string group;
        private StatusStudent status;


        public string Name { get { return nameAndSurname; } }
        public int NumberOfParticipantsInEvents { get { return numberOfParticipantsInEvents; } }
        public string Group { get { return group; } }
        public StatusStudent Status { get { return status; } }

        public Student(string nameAndSurname, string group, int numberOfParticipantsInEvents)
        {
            this.nameAndSurname = nameAndSurname;
            this.group = group;
            this.numberOfParticipantsInEvents = numberOfParticipantsInEvents;
        }

        public bool SendForceForEvent(int numberOfEvent) //Принудительная отправка
        {
            if (numberOfEvent - numberOfParticipantsInEvents > 3)
            {
                status = StatusStudent.Go;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SendAtWillForEvent(Student student) //По своему желанию
        {
            if (student.Status != StatusStudent.Go)
            {
                status = StatusStudent.Go;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GoEvent()
        {
            if (status == StatusStudent.Go)
            {
                numberOfParticipantsInEvents++;
            }
            else
            {
                Console.WriteLine("Вы не посещаете этот ивент");
            }
        }





    }
}
