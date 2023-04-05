// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//1
Console.Write("Inserisci il primo numero : ");
int num1 =Convert.ToInt32(Console.ReadLine()) ;

Console.Write("Inserisci il secondo numero : ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine("Il primo numero è magggiore del secondo");
else if (num2 > num1)
    Console.WriteLine("Il secondo numero è magggiore del primo");
else
    Console.WriteLine("I due numeri sono uguali");