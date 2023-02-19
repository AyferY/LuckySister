using LuckySistem.Consol.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LuckySistem.Consol
{
    public class SelectionManager
    {
        private List<Attendee> Attendees { get; set; }
        private List<Attendee> SelectedAttendees { get; set; }

        private Random _random;
        public SelectionManager(List<Attendee> initialAttendees)
        {

            Attendees = new List<Attendee>();
            Attendees.AddRange(initialAttendees);
            SelectedAttendees = new List<Attendee>();
            _random = new Random();
        }

        public SelectionManager()
        {
            Attendees = new List<Attendee>();

            SelectedAttendees = new List<Attendee>();
            _random = new Random();
        }

        public void AddAttendee(Attendee attendee)
        {
            Attendees.Add(attendee);
        }

        public void AddAttendee(string fullName)
        {
            Attendee attendee = new Attendee()
            {
                Id = Guid.NewGuid(),
                FullName = fullName,
                createdOn = DateTimeOffset.Now

            };
            Attendees.Add(attendee);
        }


        public void MakeSelection(int LuckyCount)
        {
            for (int i = 0; i < LuckyCount; i++)
            {

                SelectedAttendees.Add(GetRandomAttendee());
            }
        }

        public List<Attendee> GetTheLuckyOnes()
        {
            return SelectedAttendees;
        }

        private Attendee GetRandomAttendee()
        {
            var randomIndex = _random.Next(Attendees.Count);
            var attendee = Attendees[randomIndex];
            if (SelectedAttendees.Any(x => x.Id == attendee.Id))
            {
                return GetRandomAttendee();
            }
            return attendee;
        }
        public int GetAttendeesCount()
        {
            return Attendees.Count;
        }
    }
}
