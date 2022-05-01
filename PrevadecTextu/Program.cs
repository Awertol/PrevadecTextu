using PrevadecTextu;

Prevadec prevadec = new Prevadec();

Console.Write("Zadej text pro převod: ");
string input = Console.ReadLine();

prevadec.PrevadenyText = input;

//1. 
Console.WriteLine(prevadec.MalaPismena());
/*  
*2. VelkaPismena
*3. Začíná a končí stejně? ano/ne
*4. Vypsání Spongebob case 
*/
