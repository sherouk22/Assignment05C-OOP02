using System.Security.Cryptography.X509Certificates;

namespace Assignment05OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment05C#OOP02

            #region Q1   Define a struct "Person" with properties "Name" and "Age".

            //Person[] people = new Person[3];

            //people[0] = new Person("Mohamed", 19);
            //people[1] = new Person("Sherouk", 23);
            //people[2] = new Person("Eman", 19);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine($" name-->{person.Name}  Age-->{person.Age} ");
            //}

            #endregion
            #region MyRegion

            Console.WriteLine("Enter the first point:");
            Console.Write("X1: ");
            double X1 = double.Parse(Console.ReadLine());
            Console.Write("Y1: ");
            double Y1 = double.Parse(Console.ReadLine());



            Console.WriteLine("Enter the Second point:");
            Console.Write("X2: ");
            double X2 = double.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            double Y2 = double.Parse(Console.ReadLine());

            Point point1 = new Point(X1, Y1);
            Point point2 = new Point(X2, Y2);

            double distance = Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));

            Console.WriteLine($"The distance={distance}");


            #endregion



        }
    }
}
