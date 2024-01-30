using System.Collections;
using System.Runtime.CompilerServices;

namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the grade(A,B,C,D, or F):");
        char grade= char.ToUpper(Console.ReadKey().KeyChar);
        int points;
        switch (grade)
        {case 'A':
            points=4;
            break;
        case 'B':
            points = 3;
            break;
        case 'C':
            points=2;
            break;
        case 'D':
            points=1;
            break;
        case 'F':
            points=0;
            break;
        default:
            Console.WriteLine("Wrong Letter Grade!");
            return;}
        double gpa=points;
        Console.WriteLine($"ngrade {grade} corresponds to {points} points");
        Console.WriteLine($"GPA point: {gpa}");
    



    }
}
