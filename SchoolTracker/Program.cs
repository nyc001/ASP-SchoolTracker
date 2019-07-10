using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum Schools
    {
        Hogwarts = 0,
        Harvard = 1,
        MIT = 2
    }

    public static class ExtMethods
    {
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }

    class Program
    {
       
        static List<Student> students = new List<Student>();

        static void ShowGrade(string studentName)
        {
            var found = students.Find(student => student.Name == "hen");
            Console.WriteLine("student {0} has grade:{1}", found.Name, found.Grade);

        }

        static public event Action Posted;

        static void Main(string[] args)
        {
            var stat = new Stats();
            stat.Start();
            
            Payroll payroll = new Payroll();
            payroll.payAll();



            var adding = true;

            while (adding)
            {
                try
                {
                    var student = new Student();

                    student.Name = Util.Console.Ask("Enter student name:");

                    student.Grade = Util.Console.AskInt("Enter student grade:");
                    
                    student.School = (Schools)Util.Console.AskInt("Enter your school(type the coreesponding number:\n 0:) Hogwarts \n 1:)Harvard \n 2:)MIT ");
                    students.Add(student);
                    Posted?.Invoke();
                    //ShowGrade("haha");
                    Student.Count++;

                    Console.WriteLine("Student count: {0}", Student.Count);

                    Console.WriteLine("Add another student? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding student, try again");
                }

            }



            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} {item.Grade} {item.School}");
            }
        }


    }

    class Student : Member
    {
        public Student()
        {

        }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        static public int Count { set; get; } = 0;


        public int Grade { set; get; }

        public Schools School { set; get; }
    }

    class Member
    {
        public string Name { set; get; }
    }

    class Teacher : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Pay teacher");
        }
    }
}
