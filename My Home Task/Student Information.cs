using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Home_Task
{
    #region Second Task
    internal class Student_Information
    {
        public string Name;
        public string SurName;
        public string Group;
        public byte Point;
        public bool IsGraduated;


        public Student_Information(string name, string surName, string group, byte point, bool isGraduated)
        {
            Name = name;
            SurName = surName;
            Group = group;
            Point = point;
            IsGraduated = isGraduated;
        }


        public string getNameSurname()
        {
            return Name + " " + SurName;
        }


        public string allInformation()
        {
            if (IsGraduated)
            {
                Console.WriteLine("Bu telebe mezun olub");
            }
            else
            {
                Console.WriteLine("Mezun olmayib");
            }

            return Name + ", " + SurName + ", " + Group + ", " + Point;
        }

        public string canAttendToNextExam()
        {
            if (Point > 80)
            {
                return "imtahana gire biler";
            }
            else
            {
                return "imtahana buraxilmir";
            }
        }
    }
    #endregion
}
