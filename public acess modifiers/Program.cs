using publicAccessModifier;
using System;
namespace publicAccessModifier
{
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public int getRollNo()
        { return rollno; }
        public string getName()
        { return name; }
    }
}
class program
{
    static void Main(string[] args)
    {
        Student S = new Student(1, "mona");
        Student S1= new Student(2, "abc");
        Console.WriteLine("rollno : {0}", S1.rollno);
        Console.WriteLine("name : {0}",S1.name);
        Console.WriteLine("rollno : {0}", S.rollno);
        Console.WriteLine("name : {0}", S.name);
        //Console.WriteLine();

    }
}