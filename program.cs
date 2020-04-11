using System;

namespace TryInherit{ 

public class Person{
	public string Name { get; set;}
	public int Age { get; set;}

	public void GetNameAndAge(){
		Console.WriteLine("The person has name : {0} and age: {1}", Name, Age);
	}
}

public class Teacher : Person{
	public string  TeacherId { get; set;}
	public string Subject { get; set;}
}

public class Student : Person{
	public string StudentId {get; set;}
	public string Email {get; set;}
}

public class Program{
	static void Main(string[] args){
		Person person = new Person();
		person.Name = "Allen";
		person.Age = 21;
		person.GetNameAndAge();

		Teacher teacher = new Teacher();
		teacher.Name = "Lilith";
		teacher.Age = 23;
		teacher.TeacherId = "9090909";
		teacher.Subject = "Math";
		teacher.GetNameAndAge();

		Student student = new Student();
		student.Name = "Elang";
		student.Age = 19;
		student.StudentId = "19.11.2681";
		student.Email = "elang.2681@students.amikom.com";
		student.GetNameAndAge();

		Console.ReadKey();
		}
	}
}