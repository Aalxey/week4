using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task3
{
    internal class ParameterDemo
    {
        public int increase(ref int number)
        {
            number +=10;
            return number;
        }
        
        public string GetFullName(out String fullname)
        {
            String firstname = "Bishal";
            String lastname = "Rai";
            fullname = firstname + " " + lastname;
            return fullname;
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
