using System;
namespace Lab10
{
    public class Circle
    {

        #region Properties

        private double radius;
        private double circumference;
        private double area;

        #endregion


        #region fields
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }

        }

        public double Circumference
        {
            get
            {
                return circumference;
            }
            set
            {
                circumference = value;
            }
        }


        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }

        }


        public Circle()
        {
            radius = 43.42;
            circumference = 0;
            area = 0;
           
        }

        #endregion


        #region Methods
        public void PrintInfo()

        {
            Console.WriteLine("The radius is {0:0.##}", radius);
            Console.WriteLine("The circumference is  {0:0.##}",  circumference);
            Console.WriteLine("The area is {0:0.##}", area);
            
        }

        public double CalculateCircumference(double radius)
        {
            circumference = (Radius * 2)  * Math.PI;
            return circumference;
        }

        public double CalculateArea(double circumference)
        {
            circumference = (Radius * Radius) * Math.PI;
            return circumference;
        }

        #endregion


    }
}
