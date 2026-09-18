using System;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int[] Marks { get; set; }
    public Student(int id, string name, int[] marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public double CalculateAverage()
    {
        int total = 0;
        foreach (int mark in Marks)
        {
            total += mark;
        }

        return (double)total / Marks.Length;

    }
    public string GetGrade()

    {
        double average = CalculateAverage();

        if (average >= 90)
            return "A+";
        else if (average >= 80)
            return "A";
        else if (average >= 70)
            return "B";
        else if (average >= 60)
            return "C";
        else if (average >= 50)
            return "D";
        else
            return "F";

    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student ID:" + Id);
        Console.WriteLine($"Name:" +Name);
        Console.WriteLine($"Average Marks:" +CalculateAverage().ToString("F2"));
        Console.WriteLine($"Grade:" +GetGrade());
        Console.WriteLine();
    }

}
class Program
{
    static void Main()
    {
        Student student1 = new Student(
            1,
            "Rahul",
            new int[] { 85, 90, 78, 87, 94 }
        );
        Student student2 = new Student(
            2,
            "Ananya",
            new int[] { 70, 81, 75, 80, 77 }
        );
        Student student3 = new Student(
            2,
            "Anu",
            new int[] { 55, 80, 61, 58, 77 }
        );
        student1.DisplayDetails();
        student2.DisplayDetails();
        student3.DisplayDetails();
    }


}