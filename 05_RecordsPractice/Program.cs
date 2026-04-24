using System;

//Records
Console.WriteLine("Records:");
var user1 = new UserDto(1, "Khang", "IT");
var user2 = new UserDto(1, "Khang", "IT");

Console.WriteLine($"User1 == User2? {user1 == user2}");
Console.WriteLine($"User1: {user1}");

//Pattern matching
Console.WriteLine("Pattern matching (Switch Expression):");
string roleAccess = user1.Role switch
{
    "IT" => "Bạn có toàn quyền truy cập Server.",
    "HR" => "Bạn có quyền xem hồ sơ nhân sự.",
    "PM" => "Bạn có quyền quản lý dự án.",
    _ => "Role không hợp lệ."
};
Console.WriteLine($"Nếu bạn là {user1.Role}: {roleAccess}");

Console.WriteLine("Non-destructive Mutation:");
var user3 = user1 with { Role = "PM" };
Console.WriteLine($"User is now {user3}.");

public record UserDto(int ID, string Name, string Role);