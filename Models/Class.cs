using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationExercise.Models
{
    public class Class
    {
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int GetNumberOfEnrolledStudents()
        {
            int amount = Students.Count;
            return amount;
        }
        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void ListStudents() 
        {
            Console.WriteLine($"English's class students: {Name}");
            foreach(Person student in Students)
            {
                Console.WriteLine(student.CompletName);
            }
        }

    }
}