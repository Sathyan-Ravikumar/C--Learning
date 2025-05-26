using C__Learning;
using System.Runtime.Intrinsics.Arm;

List<Student> students = new List<Student>();

//Adding Students
students.Add(new Student
{
    Id = 1,
    Name = "Sathyan",
    HomeAddress = new Address("Coimbatore", "Tamil Nadu"),
    Status = StudentStatus.Active,
    Skills = { "C#", "React", "Angular" }

});

students.Add(new Student
{
    Id = 2,
    Name = "Arun",
    HomeAddress = new Address("Salem", "Tamil Nadu"),
    Status = StudentStatus.Graduated,
    Skills = {"C#","SQL","C#"}
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

//Value vs Reference 
Console.WriteLine("\nReference Type Demo:");
var original = students[0];
var copy = original; // reference copy
copy.Name = "Changed Name";

Console.WriteLine("Original Name: " + students[0].Name); //show changed name

Console.WriteLine("\nValue Type Demo:");
Address addr1 = new Address("Chennai", "TN");
Address addr2 = addr1;
addr2.City = "Madurai";

Console.WriteLine($"addr1.City: {addr1.City}"); // Chennai
Console.WriteLine($"addr2.City: {addr2.City}"); // Madurai