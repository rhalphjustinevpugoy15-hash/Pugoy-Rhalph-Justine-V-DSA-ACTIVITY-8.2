using System;
using System.Collections;

class Student
{
    public string StudentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNo { get; set; }

    public Student(string studentId, string name, string address, string contactNo)
    {
        StudentId = studentId;
        Name = name;
        Address = address;
        ContactNo = contactNo;
    }
}

class Program
{
    static void Main()
    {
        Hashtable records = new Hashtable();

        records.Add("101", new Student("101", "Jose Marie Chou", "Solano", "N/A"));
        records.Add("102", new Student("102", "Marites Alcantara", "Bayombong", "09273744546"));
        records.Add("103", new Student("103", "Pepito Montalban", "Aritao", "09184476548"));

        Console.WriteLine("Welcome to my HASHTABLE Program");

        string searchAgain;
        do
        {
            Console.WriteLine("Here are the available records:");
            Console.WriteLine("Student ID");
            Console.WriteLine("101");
            Console.WriteLine("102");
            Console.WriteLine("103");
            Console.WriteLine();

            Console.Write("Enter look up id: ");
            string lookupId = (Console.ReadLine() ?? "").Trim();

            if (records.ContainsKey(lookupId))
            {
                Student s = (Student)records[lookupId]!;
                Console.WriteLine();
                Console.WriteLine("Here is the detailed information:");
                Console.WriteLine($"Student ID:\t{s.StudentId}");
                Console.WriteLine($"Name:\t\t{s.Name}");
                Console.WriteLine($"Address:\t{s.Address}");
                Console.WriteLine($"Contact no:\t{s.ContactNo}");
            }
            else
            {
                Console.WriteLine("Record is not existing!");
            }

            Console.WriteLine();
            Console.Write("Would you like to search another record? [Y/N]: ");
            searchAgain = (Console.ReadLine() ?? "").Trim().ToUpper();
            Console.WriteLine();

        } while (searchAgain == "YES");
    }
}