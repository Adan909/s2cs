// leer un numero entero

int numero = 0;
do
{
    Console.Write("Digite un numero: ");
    try
    {
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El numero ingresado fue {numero}");

    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }

    catch (Exception ex)

    {
        Console.WriteLine(ex.Message);
    }
} while (numero != 0);

