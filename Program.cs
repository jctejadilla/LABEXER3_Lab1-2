using System;
namespace StudentGradeApplication;

public class frmStudentGradeProgram
{
    public static void Main(string[] args)
    {
       Console.WriteLine ("Student Grade Application");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Course: ");
        string course = Console.ReadLine();
        
        Console.Write ("Enter grade in English: ");
        double gEnglish = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Enter grade in Math: ");
        double gMath = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Enter grade in Science: ");
        double gScience = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Enter grade in Filipino: ");
        double gFilipino = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Enter grade in History: ");
        double gHistory = Convert.ToDouble(Console.ReadLine());
        
        double sum = (gEnglish + gMath + gScience + gFilipino + gHistory);
        double average = sum / 5;
        double RoundedAve = Math.Round(average);

        Console.WriteLine("");
        Console.WriteLine("===Student Grade Application Summary===");
        Console.WriteLine("");

        if(RoundedAve > 75){
            Console.WriteLine("Student has passed!");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The rounded average of student {name} is: {RoundedAve}");
        } else {
            Console.WriteLine("Student has failed!");
            Console.WriteLine($"The average of student {name} is: {RoundedAve}");
        }   
        
    }
}