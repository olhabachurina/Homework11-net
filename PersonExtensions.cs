using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace People
{
    public static class PersonExtensions
    {
        public static double AverageAge(this Person[] people)
        {
            if (people == null || people.Length == 0)
            {
                throw new ArgumentException("The array is empty or null.");
            }

            return people.Average(person => person.Age);
        }
    }
}