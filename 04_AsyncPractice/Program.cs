using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

//Async I/O read file
Console.WriteLine("Đọc/Ghi File:");
string filePath = "demo.txt";

Console.WriteLine("Đang ghi file...");
await File.WriteAllTextAsync(filePath, "Xin Chào, Hello, Bonjour, Halo");

Console.WriteLine("Đang đọc file...");
string content = await File.ReadAllTextAsync(filePath);
Console.WriteLine($"Nội dung file: {content}\n");

//Async I/O Http calling
Console.WriteLine("Call HTTP API:");

using HttpClient client = new HttpClient();
Console.WriteLine("Calling API: Lấy thông tin User 1 từ URL");
string apiRes = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users/1");

Console.WriteLine("Dữ liệu nhận được:");
Console.WriteLine(apiRes.Substring(0, Math.Min(150, apiRes.Length)) + "...");