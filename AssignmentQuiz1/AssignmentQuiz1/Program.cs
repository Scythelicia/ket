using System;

public class Person 
{
    public string name { get; set; }
    public int weight { get; set; }
}
public class Program
{
    public static void Main(string[] args) {
        List<Person> list = new List<Person>();

        while (true)
        {
            Console.WriteLine("Enter new Data? Y/N");
            if (Console.ReadLine() == "N")
            {
                break;
            }
            Person person = new Person();
            Console.Write("Please enter your name>>");
            person.name = Console.ReadLine();
            Console.Write("Enter your weight>>");
            person.weight = int.Parse(Console.ReadLine());

            list.Add(person);
        }
        list.ForEach(x => {
            Console.WriteLine("Name: " + x.name);
            Console.WriteLine("Weight: " + x.weight);
            Console.WriteLine("___________________________");
            
            
            
            });
    }
    
}