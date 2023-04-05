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
//int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int somma = 0;

//for (var i = 0; i < array.Length; i++)
//{
//    somma += array[i];
//}
//Console.WriteLine($"La somma dei numeri è : {somma}");
//Console.WriteLine($"La media dei numeri è : {somma / array.Length}");

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

//int[] array = new int[6];

//for (var i = 0; i < 6; i++)
//{
//    Console.Write($"Inserisci il {i + 1} numero : ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num % 2 != 0)
//        array[i] = num;
//}
//for (var i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}

//snack 8

//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int somma = 0;
//for(var i = 0; i< array.Length; i++)
//{
//    if (i % 2 != 0)
//        somma += array[i];
//}
//Console.WriteLine($"La somma dei numeri dispari è {somma}");

//snack 9


//int[] array = Array.Empty<int>();
//do
//{

//        Console.Write("Inserisci un numero : ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        array =  array.Append(num).ToArray();

//}
//while (array.Sum() < 50);


//for(var i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]);
//}


//snack 10

//Console.Write("Inserisci un numero : ");
//int num =Convert.ToInt32(Console.ReadLine());
//Random rnd = new Random();
//for(var i = 0;i < num; i++)
//{
//    int[] array = new int[10];
//    for (var b = 0; b < array.Length; b++)
//    { 
//         array[b] = rnd.Next(1, 101);

//    }
//    Console.WriteLine("[{0}]", string.Join(", ", array));

//}
// snack 11
Console.Write("Inserisci due parole : ");
var words = Console.ReadLine().Split(' '); 
string word1 = words[0]; 
string word2 = words[1]; 
if(word1.Length == word2.Length)
{
    Console.WriteLine(word1);
    Console.WriteLine(word2);
}
else if(word1.Length > word2.Length)
    Console.WriteLine(word1);
else
    Console.WriteLine(word2);