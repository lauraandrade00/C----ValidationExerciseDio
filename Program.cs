using ValidationExercise.Models;

Person p1 = new Person(name: "Laura",lastname: "Andrade");
Person p2 = new Person(name: "John", lastname: "Wayne");

Class englishClass = new Class();
englishClass.Name = "English";
englishClass.Students = new List<Person>();

englishClass.AddStudent(p1);
englishClass.AddStudent(p2);
englishClass.ListStudents();

