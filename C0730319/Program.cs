using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730319
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    StudentInformation _Mary = new StudentInformation("Mary", 3.8, 20);
                    StudentInformation _john = new StudentInformation("john", 3.8, 20);
                    StudentInformation _mark = new StudentInformation("mark", 3.8, 20);
                    StudentInformation _steve = new StudentInformation("steve", 3.8, 20);
                    StudentInformation _cindy = new StudentInformation("cindy", 3.8, 20);
                    var studentlist = new List<StudentInformation>();
                    studentlist.Add(_Mary);
                    studentlist.Add(_john);
                    studentlist.Add(_mark);
                    studentlist.Add(_steve);
                    studentlist.Add(_cindy);
                    foreach (var student in studentlist)
                    {
                        Console.WriteLine(student.Name);
                    }
                    Console.ReadLine();
                }
            }
        }

        class StudentInformation

        {
            public string Name;
            public double GPA;
            public int Attendence;
            public StudentInformation(string aName, double cGPA, int dAttendence)

            {
                Name = aName;

                GPA = cGPA;
                Attendence = dAttendence;
            }
        }
    }
}

