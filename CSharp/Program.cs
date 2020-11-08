using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Schema;

namespace CSharp
{
    internal class Major { }
    internal class SQL : Major { }
    public class Person<T> { }

    public class Person /*: Person<T> */
    {
        public int Age { get; set; }
        public bool? IsMale { get; set; }
        public string Name { get; internal set; }

        public void Greet(Person person)
        {
            //Nullable<bool> bool?

            //string? name = "";

            person.Age++;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            //IList<Student> students = new List<Student>
            //{
            //    new Student(){ Name = "lw" },
            //    new Student(){ Name = "zdh" },
            //    new Student(){ Name = "lgy" },
            //    new Student(){ Name = "zl" },
            //};

            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i].Name);
            //}


            //foreach (Student item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //IEnumerator<Student> enumerator = students.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var item = enumerator.Current;
            //    Console.WriteLine(item);
            //}



            foreach (var item in new Student())
            {

            }


            //Dictionary<string, Student> students = new Dictionary<string, Student>
            //{
            //    {"lw", new Student() },            
            //    {"gty", new Student() },            
            //    {"lgy", new Student() },
            //};

            ////for (int i = 0; i < students.Count; i++)
            ////{
            ////    Console.WriteLine(students[i]);
            ////}

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Key);
            //}

        }
    }


    public interface ILearn
    {
        void Study();
    }

    public interface ILearn<T>
    {
        T Exam();
        void Teach(T major);
    }

    public class Bed
    {
        public double Price { get; set; }
    }


}
