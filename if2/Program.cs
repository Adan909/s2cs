int numero, numero2;
try
{
    Console.Write("Ingrese un numero: ");
    numero = int.Parse(Console.ReadLine()!);
    Console.Write("Ingresa un segundo numero: ");
    numero2 = int.Parse(Console.ReadLine()!);
    int div = numero / numero2;
    Console.WriteLine($"La division es {div}");

}
catch (FormatException ex)
{
    Console.WriteLine($"{ex.Message}");

}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"{ex.Message}");
}