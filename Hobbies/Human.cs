using System;

namespace Hobbies
{
    public class Human : EventArgs
    {
        public delegate void ReactionDelegate(string _event);
        public static event ReactionDelegate ReactionToEvent;
        readonly string personName;
        private string[] hobbies;
        public string[] Hobbies { get { return hobbies; } }
        public Human(string personName, params string[] hobbies)
        {
            this.personName = personName;
            this.hobbies = hobbies;
        }
        public Human() { }
        public static void RaiseEvent(string[] events, string _eventNum)
        {
             ReactionToEvent?.Invoke( events[int.Parse(_eventNum) - 1]);
        }
        public void React(string _event)
        {
            if (ReactionToEvent != null)
            {
                Console.WriteLine($"{personName}: Урааа {_event}");
            }
        }

    }
}
