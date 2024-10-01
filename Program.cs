namespace LoopingModuleActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade:");
            string input = Console.ReadLine();

            if (!float.TryParse(input, out float grade))
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.");
                return;
            }

            string description, usGrade, equivalent;

            if (grade >= 96.00 && grade <= 100.00)
            {
                description = "Excellent";
                usGrade = "A+";
                equivalent = "1.00 - 1.24";
            }
            else if (grade >= 94.00 && grade <= 95.99)
            {
                description = "Superior";
                usGrade = "A";
                equivalent = "1.25 - 1.49";
            }
            else if (grade >= 91.00 && grade <= 93.99)
            {
                description = "Very Good";
                usGrade = "A-";
                equivalent = "1.50 - 1.74";
            }
            else if (grade >= 89.00 && grade <= 90.99)
            {
                description = "Good";
                usGrade = "B+";
                equivalent = "1.75 - 1.99";
            }
            else if (grade >= 86.00 && grade <= 88.99)
            {
                description = "Very Satisfactory";
                usGrade = "B";
                equivalent = "2.00 - 2.24";
            }
            else if (grade >= 83.00 && grade <= 85.99)
            {
                description = "High Average";
                usGrade = "B-";
                equivalent = "2.25 - 2.49";
            }
            else if (grade >= 80.00 && grade <= 82.99)
            {
                description = "Average";
                usGrade = "C+";
                equivalent = "2.50 - 2.74";
            }
            else if (grade >= 77.00 && grade <= 79.99)
            {
                description = "Fair";
                usGrade = "C";
                equivalent = "2.75 - 2.99";
            }
            else if (grade >= 75.00 && grade <= 76.99)
            {
                description = "Pass";
                usGrade = "C-";
                equivalent = "3.00 - 3.99";
            }
            else if (grade >= 70.00 && grade <= 74.99)
            {
                description = "Conditional";
                usGrade = "D";
                equivalent = "4.00 - 4.99";
            }
            else if (grade >= 0.00 && grade <= 69.99)
            {
                description = "Failing";
                usGrade = "F";
                equivalent = "5.00";
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.");
                return;
            }

            Console.WriteLine($"US Grade: {usGrade}");
            Console.WriteLine($"Equivalent: {equivalent}");
            Console.WriteLine($"Grade Description: {description}");
        }
    }
}