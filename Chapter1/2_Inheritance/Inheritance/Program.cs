using System;

namespace Inheritance
{
    // Parent class (Person)
    public class Person
    {
        private int age;
        private string name;
        private string address;

        public void SetPerson(int age, string name, string address)
        {
            this.age = age;
            this.name = name;
            this.address = address;
        }

        public void DisplayPerson()
        {
            Console.WriteLine("Age: " + age + ", Name: " + name + ", Address: " + address);
        }
    }

    // Child class (Student) inheriting from Person
    public class Student : Person
    {
        private string faculty;
        private string grade;

        public void SetStudent(string faculty, string grade)
        {
            this.faculty = faculty;
            this.grade = grade;
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Faculty: " + faculty + ", Grade: " + grade);
        }
    }

    // Child class (PrimaryStudent) inheriting from Student - for multilevel inheritance
    public class PrimaryStudent : Student
    {
        private int level;

        public void SetPrimary(int level)
        {
            this.level = level;
        }

        public void DisplayPrimary()
        {
            Console.WriteLine("Level: " + level);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Student class
            Student student = new Student();
            // Accessing parent (Person) properties
            student.SetPerson(20, "Atullya Maharjan", "Bafal");
            student.DisplayPerson();
            // Accessing own properties
            student.SetStudent("Computer Science", "A");
            student.DisplayStudent();

            // Multilevel inheritance with PrimaryStudent
            PrimaryStudent primaryStudent = new PrimaryStudent();
            // Accessing grandparent (Person) properties
            primaryStudent.SetPerson(5, "Hari", "Pokhara");
            primaryStudent.DisplayPerson();
            // Accessing parent (Student) properties
            primaryStudent.SetStudent("Kindergarten", "A+");
            primaryStudent.DisplayStudent();
            // Accessing own (PrimaryStudent) properties
            primaryStudent.SetPrimary(5);
            primaryStudent.DisplayPrimary();
        }
    }
}
