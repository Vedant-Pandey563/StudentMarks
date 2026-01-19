using System;

class Program
{
    static void Main()
    {
        string name = "Rahul";
        int marks = 80;
        int totalMarks = 100;

        int percentage = (marks * 100) / totalMarks;

        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Percentage: " + percentage + "%");
    }
}

