using System;
using System.Collections.Generic;

namespace StudentClasses
{
    abstract class Student
    {
        public string name, state;

        public Student(string name)
        {
            this.name = name;
            state = "";
        }
        protected void Read()
        {
            state += "Read";
        }
        protected void Relax()
        {
            state += "Relax";
        }
        protected void Write()
        {
            state += "Write";
        }
        public abstract void Study();
    }


    class GoodStudent : Student
    {
        public GoodStudent(string name) : base(name)
        {
             state += "good";
        }
        public override void Study()
        {
             Read();
             Write();
             Read();
             Write();
             Relax();
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            state += "bad";
        }
        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }
    class Group
    {
        private string name;
        private List<Student> students;
        public Group(string name)
        {
           students = new List<Student>();
           this.name = name;
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void GetInfo()
        {
            Console.WriteLine("In group {0} there are:", name);
            foreach (Student student in students)
            {
                Console.WriteLine("student {0}", student);
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine("In group {0} there are:", name);
            foreach (Student student in students)
            {
                Console.WriteLine("student {0} with status {1}", student.name, student.state);
            }
        }
    }
    class Program
    {
        static void AddStudent(ref Group group)
        {
            Console.WriteLine("Next student: Will student be good or bad?");
            string student_type = Console.ReadLine();
            if (student_type == "good")
            {
                Console.WriteLine("Inpute student's name:");
                string student_name = Console.ReadLine();
                GoodStudent student = new GoodStudent(student_name);
                student.Study();
                group.AddStudent(student);
            }
            else if (student_type == "bad")
            {
                Console.WriteLine("Inpute student's name:");
                string student_name = Console.ReadLine();
                BadStudent student = new BadStudent(student_name);
                student.Study();
                group.AddStudent(student);
            }
            else
            {
                Console.WriteLine("Error: Unknown command");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input name of group:");
            string group_name = Console.ReadLine();
            Group group = new Group(group_name);
            Console.WriteLine("Input number of commands:");
            int commands_number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < commands_number; i++)
            {
                Console.WriteLine("Input command:");
                string command = Console.ReadLine();
                if(command == "AddStudent")
                {
                    AddStudent(ref group);
                }

                if(command == "GetInfo")
                {
                    group.GetInfo();
                }

                if(command == "GetFullInfo")
                {
                    group.GetFullInfo();
                }
            }
        }
    }
}
