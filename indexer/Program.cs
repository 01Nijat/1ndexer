// See https://aka.ms/new-console-template for more information
using indexer;
using System.Reflection;

Console.WriteLine("Indexer");
Employee employee1 = new Employee();
employee1.Id = 1;
employee1.name = "Nijat";
NtCompany NtCompany = new NtCompany(11);
NtCompany[1] = employee1;
Console.WriteLine(NtCompany[1]);

//Assembly
//Assembly assembly= Assembly.GetExecutingAssembly();
//foreach (var item in assembly.GetTypes())
//{
//    Console.ForegroundColor= ConsoleColor.Red;
//    Console.WriteLine(item.Name +" : ");
//    foreach (var i in item.GetMembers())
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine(i);
//    }
//}