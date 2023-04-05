// See https://aka.ms/new-console-template for more information

//snack 1

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


//snack 2

//Console.Write("Inserisci la prima parola : ");
//string parola1 = Console.ReadLine();
//Console.Write("Inserisci la seconda parola : ");
//string  parola2 = Console.ReadLine();
//if (parola1.Length < parola2.Length)
//    Console.WriteLine($"La parola più corta è : {parola1} quella più lunga è : {parola2}");
//else if(parola2.Length < parola1.Length)
//    Console.WriteLine($"La parola più corta è : {parola2} quella più lunga è : {parola1}");
//else
//    Console.WriteLine($"Le due parole hanno la stessa lunghezza");


//snack 3

//int somma = 0;
//for(var i = 0; i < 10; i++)
//{
//    Console.Write($"Inserisci il {i+1} numero  : ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    somma += num;

//}
//Console.Write($"La somma dei numeri è : {somma}");


//snack 4

//int somma = 0;
//for (var i = 2; i < 11; i++)
//{
//    somma += i;
//}
//Console.WriteLine($"La somma dei numeri è : {somma}");
//Console.WriteLine($"La media dei numeri è : {somma / 9}");

//snack 5

//Console.Write("Inserisc un numero : ");
//int numero = Convert.ToInt32(Console.ReadLine());
//if (numero % 2 == 0)
//    Console.WriteLine($"{numero}");
//else
//    Console.WriteLine($"{numero + 1}");


//snack 6

//string[] arrayInvitati = { "Luca", "Antonio", "Mario", "Luigi", "Paolo", "Alessandro" };
//Console.Write("Inserisci il tuo nome : ");
//string nome = Console.ReadLine();

//if (nome == "" || nome == null)

//    Console.WriteLine("Devi inserire un nome valido");

//if (arrayInvitati.Contains(nome))
//    Console.WriteLine("Sei stato invitato alla festa");

//else
//    Console.WriteLine("Non sei stato invitato alla festa");

// snack 7

int[] array = new int[6];
for(var i = 0; i< 6; i++)
{
    Console.Write($"Inserisci il {i + 1} numero : ");
   int num = Convert.ToInt32( Console.ReadLine());
    if (num % 2 != 0)
        array[i] = num;
}
for( var i = 0; i< array.Length; i++)
{
    Console.WriteLine(array[i]);
}