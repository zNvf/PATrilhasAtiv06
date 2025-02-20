using System;
class Program
{
public static void Main()
{
for (int contador = 0; contador < 101; contador++){
if (contador % 2 == 0) {
Console.Write(contador+ " ");
}
}
Console.WriteLine();
Console.WriteLine("\n\rPress any key to continue . . . ");
Console.ReadKey(true);
}
}
