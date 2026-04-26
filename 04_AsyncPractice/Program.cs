using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    private static readonly HttpClient _client = new HttpClient();

    static async Task Main(string[] args)
    {
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

        Console.WriteLine("Calling API: Lấy thông tin User 1 từ URL");
        string apiRes = await _client.GetStringAsync("https://jsonplaceholder.typicode.com/users/1");

        Console.WriteLine("Dữ liệu nhận được:");
        Console.WriteLine(apiRes.Substring(0, Math.Min(150, apiRes.Length)) + "...");
    }
}