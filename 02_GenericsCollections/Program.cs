using System;
using System.Collections.Generic;

Storage<string> stringStorage = new Storage<string>();
stringStorage.Save("Hello Khang");
Console.WriteLine($"Storage content: {stringStorage.Get()}");

Storage<int> intStorage = new Storage<int>();
intStorage.Save(10000);
Console.WriteLine($"Storage content: {intStorage.Get()}");

List<string> fruits = new List<string>{ "Apple", "Banana" };
fruits.Add("Cherry");

foreach (string fruit in fruits)
{
    Console.WriteLine($"- {fruit}");
}

Dictionary<int, string> roles = new Dictionary<int, string>();
roles.Add(1, "CEO");
roles.Add(2, "HR");
roles[3] = "PM";

if (roles.ContainsKey(1))
{
    Console.WriteLine($"ID 1: {roles[1]}");
}

foreach (KeyValuePair<int, string> kvp in roles)
{
    Console.WriteLine($"ID: {kvp.Key} - Role: {kvp.Value}");
}


public class Storage<T>
{
    private T? _item;

    public void Save(T? item)
    {
        _item = item;
    }

    public T? Get()
    {
        return _item;
    }
}