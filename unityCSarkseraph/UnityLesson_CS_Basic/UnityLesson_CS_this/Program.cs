using System;

/*namespace UnityLesson_CS_this
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/

public class Employee
{
    private string company;
    private string name;

    public Employee(string name, string company)
    {
        this.name = name;
        this.company = company;
    }
}