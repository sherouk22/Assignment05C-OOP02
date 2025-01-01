namespace Assignment05OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

             Person[] people = new Person[3];

            people[0] = new Person("Ahmed",22);
            people[1] = new Person("Sherouk", 23);
            people[2] = new Person("Eman", 19);

            foreach (Person person in people)
            {
                Console.WriteLine($" name-->{person.Name}  Age-->{person.Age} ");
            }
        }
    }
}
