using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Student : Person, IEnumerable
    {


        internal static object[] students =
        {
            new Student(){ Name = "lw" },
            new Student(){ Name = "zdh" },
            new Student(){ Name = "lgy" },
            new Student(){ Name = "zl" }
        };

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        struct Enumerator : IEnumerator
        {
            private object _current;
            private object[] _localStudents;
            private int _index;
            

            public Enumerator(Student student)
            {
                _localStudents = Student.students;
                _index = 0;
                _current = _localStudents[_index];
            }

            public object Current => _current;

            public bool MoveNext()
            {
                _index++;

                if (_index >= _localStudents.Length)
                {
                    return false;
                }

                _current = _localStudents[_index];
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}