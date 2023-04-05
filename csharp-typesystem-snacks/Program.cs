// See https://aka.ms/new-console-template for more information

//1 snack

//Console.Write("Inserisci il primo numero : ");
//int num1 =Convert.ToInt32(Console.ReadLine()) ;

//Console.Write("Inserisci il secondo numero : ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//    Console.WriteLine("Il primo numero è magggiore del secondo");
//else if (num2 > num1)
//    Console.WriteLine("Il secondo numero è magggiore del primo");
//else
//    Console.WriteLine("I due numeri sono uguali");


//2 snack

Console.Write("Inserisci la prima parola : ");
string parola1 = Console.ReadLine();
Console.Write("Inserisci la seconda parola : ");
string  parola2 = Console.ReadLine();
if (parola1.Length < parola2.Length)
    Console.WriteLine($"La parola più corta è : {parola1} quella più lunga è : {parola2}");
else if(parola2.Length < parola1.Length)
    Console.WriteLine($"La parola più corta è : {parola2} quella più lunga è : {parola1}");
else
    Console.WriteLine($"Le due parole hanno la stessa lunghezza");
