using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Afag";
            student.Surname = "Dadashova";
            student.Group = "P324";
            student.Graduated = "Is graduated";

            Console.WriteLine(student.getInfo());
            
        }
        
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public string Graduated;

        public string getInfo()
        {
            return $"Name:{Name}, Surname:{Surname}";


        }
              
              
    }
        
            
        
    
}
