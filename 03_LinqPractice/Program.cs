using System;
using System.Collections.Generic;
using System.Linq;

List<Person> peopleList = new List<Person>
{
    new Person { Name = "A", Age = 19, Department = "IT" },
    new Person { Name = "B", Age = 25, Department = "HR" },
    new Person { Name = "C", Age = 30, Department = "Marketing" },
    new Person { Name = "G", Age = 22, Department = "IT" },
    new Person { Name = "K", Age = 21, Department = "IT" }
};

Console.WriteLine("Filter & Map Demo");
//Example: Tìm tên của những người ở phòng IT, trên 20 tuổi, sắp xếp tên theo A-Z.
var itNames = peopleList.Where(p => p.Department == "IT" && p.Age > 20).OrderBy(p => p.Name).Select(p => p.Name).ToList();

foreach (var name in itNames)
{
    Console.WriteLine($"- {name}");
}

Console.WriteLine("Group Demo");
//Example: Gom nhóm nhân viên theo phòng ban
var groupedByDept = peopleList.GroupBy(p => p.Department);

foreach (var group in groupedByDept)
{
    Console.WriteLine($"Dept: {group.Key}: {group.Count()} people");
    foreach (var p in group)
    {
        Console.WriteLine($"  - {p.Name} - {p.Age} years old.");
    }
}

Console.WriteLine("Aggregate Demo");
double avgAge = peopleList.Average(p => p.Age);
int maxAge = peopleList.Max(p => p.Age);
int totalAge = peopleList.Aggregate(0, (total, p) => total + p.Age);
string allNames = peopleList.Aggregate("", (seq, p) =>
{
    if (seq == "")
    {
        return p.Name;
    }
    else
    {
        return seq + ", " + p.Name;
    }
});

Console.WriteLine($"Average Age: {avgAge}");
Console.WriteLine($"The oldest: {maxAge}");
Console.WriteLine($"Total Age: {totalAge}");
Console.WriteLine($"Name list: {allNames}");

public class Person()
{
    public required string Name { get; set; }
    public int Age { get; set; }
    public required string Department { get; set; }
}