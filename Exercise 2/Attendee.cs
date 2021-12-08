using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Attendee
    {
        public string firstName;
        public string lastName;
        public string emailAdress;
        public int age;
        public string allergies;

        public Attendee(string firstName, string lastName, string emailAdress, int age, string allergies)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAdress = emailAdress;
            this.age = age;
            this.allergies = allergies;
        }
    }
}
