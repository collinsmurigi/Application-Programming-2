using System;

class Student
{
    // Fields
    public string Name;
    public int Age;
    public string Major;

    // Constructor
    public Student(string name, int age, string major)
    {
        Name = name;
        Age = age;
        Major = major;
    }

    // Method to display student details
    public void DisplayDetails()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Major: {Major}");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Student class
        Student student = new Student("Johnny Walker", 24, "Economics and Finance");

        // Print student details
        student.DisplayDetails();
    }
}

