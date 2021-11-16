using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzięwietnasty
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student( string Name, string Major, double gpa)
        {
            this.name = Name;
            this.major = Major;
            this.gpa = gpa;
        }

        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
