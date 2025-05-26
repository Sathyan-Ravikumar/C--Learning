using C__Learning;
using System.Runtime.Intrinsics.Arm;

List<Student> students = new List<Student>();

//Adding Students
students.Add(new Student
{
    Id = 3,
    Name = "Sathyan",
    HomeAddress = new Address("Coimbatore", "Tamil Nadu"),
    Status = StudentStatus.Active,
    Skills = { "C#", "React", "Angular" }

});

students.Add(new Student
{
    Id = 1,
    Name = "Arun",
    HomeAddress = new Address("Salem", "Tamil Nadu"),
    Status = StudentStatus.Graduated,
    Skills = {"C#","SQL","C#"}
});
students.Add(new Student
{
    Id = 2,
    Name = "Arun", // Duplicate name
    HomeAddress = new Address("Chennai", "Tamil Nadu"),
    Status = StudentStatus.Active,
    Skills = { "Java", "Spring" }
});
//Dictionary to lookup by ID

Dictionary<int, Student> studentDict = new Dictionary<int, Student>();


foreach (var student in students)
{
    studentDict[student.Id] = student;
}

Console.WriteLine("All Students:");

/*foreach (var s in students)
{
    Console.WriteLine(s);
}*/

// display all the students with skills stored in hashset
foreach (var student in students)
{
    Console.WriteLine(student);

    Console.WriteLine("Skills:");
    foreach (var skill in student.Skills)
    {
        Console.WriteLine($" - {skill}");
    }
}

//Sorted Dictionary

SortedDictionary<int, Student> sortedDictionary = new SortedDictionary<int, Student>();

foreach (var student in students)
{
    sortedDictionary[student.Id] = student;
}
Console.WriteLine();
Console.WriteLine("--- All Students - Sorted Dictionary: ---");

foreach (var kvp in sortedDictionary)
{
    Console.WriteLine(kvp.Value);

    Console.WriteLine("Skills:");
    foreach (var skill in kvp.Value.Skills)
    {
        Console.WriteLine($" - {skill}");
    }
}


//Value vs Reference 
Console.WriteLine("\n --- Reference Type Demo: ---");
var original = students[0];
var copy = original; // reference copy
copy.Name = "Rahul";

Console.WriteLine("Original Name: " + students[0].Name); //show changed name

Console.WriteLine("\n --- Value Type Demo: ---");
Address addr1 = new Address("Chennai", "TN");
Address addr2 = addr1;
addr2.City = "Madurai";

Console.WriteLine($"addr1.City: {addr1.City}"); // Chennai
Console.WriteLine($"addr2.City: {addr2.City}"); // Madurai


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--- All Students in sorted List ---");
SortedList<string, List<Student>> sortedList1 = new SortedList<string, List<Student>>();

foreach (var student in students)
{
    if (!sortedList1.ContainsKey(student.Name))
        sortedList1[student.Name] = new List<Student>();

    sortedList1[student.Name].Add(student);
}

// Display all students sorted by name
foreach (var kvp in sortedList1)
{
    foreach (var student in kvp.Value)
    {
        Console.WriteLine(student);

        Console.WriteLine("Skills:");
        foreach (var skill in student.Skills)
        {
            Console.WriteLine($" - {skill}");
        }

        Console.WriteLine();
    }
}
