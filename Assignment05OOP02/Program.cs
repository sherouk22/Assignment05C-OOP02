namespace Assignment05OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Assignment05C#OOP02

             Person[] people = new Person[3];

            people[0] = new Person("Mohamed",19);
            people[1] = new Person("Sherouk", 23);
            people[2] = new Person("Eman", 19);

            foreach (Person person in people)
            {
                Console.WriteLine($" name-->{person.Name}  Age-->{person.Age} ");
            }
        }
    }
}
