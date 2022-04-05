using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_Day4
{
    public class AgeException : Exception
    {
        public AgeException(string msg) : base(msg) { }
    }

    public class user
    {
        public int AcceptAge(int age)
        {
            if (age < 18)
            {
                throw new AgeException("This user is not valid for vote");
            }
            return age;
        }
    }
}
