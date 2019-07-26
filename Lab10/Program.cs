using System;


namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            int circleCounter = 1;

            //Calling Circle Class
            Circle circle = new Circle();

                Console.WriteLine("Welcome the circle tester");


            //Creating loop for entering data
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Enter in your radius");
                circle.Radius = double.Parse(Console.ReadLine());


                //Uses method from Circle class to calculate the Cicumference (2*R*PI) given the user input
                circle.Circumference = circle.CalculateCircumference(circle.Circumference);


                //Uses method from Circle class to calculate the area(PI * R(squared) given the user input
                circle.Area = circle.CalculateArea(circle.Area);

                //Prints Radius + Circumference + Area
                circle.PrintInfo();

                //Prompts user to add in another circle
                bool askAgain = AskForAnotherCircle();
                if (askAgain == true)
                {
                    circleCounter++; //Add 1 to Circle Counter
                    loop = true; // Repeats loop
                }

                else
                {
                    Console.WriteLine("You created " + circleCounter + " circles");
                    System.Environment.Exit(1); //Exits Program

                }
            }
        }

            public static bool AskForAnotherCircle()
            {

            Console.WriteLine("Would you like to enter in data again?(yes or no)");
            string userAnswer = Console.ReadLine();
            if(userAnswer == "yes")
            {
                return true;
            }

            return false;

            }
        
    }
}
