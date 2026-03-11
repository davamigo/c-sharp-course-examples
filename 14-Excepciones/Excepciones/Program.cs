public class Program
{
    private static void EjemploTryCatch()
    {
        int num;

        do {
            try {
                Console.Write("Escribe un número del 1 al 10 (o 0 para acabar): ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 10)
                {
                    Console.WriteLine("Número incorrecto!");
                }
                else
                {
                    Console.WriteLine("Tu número es: " + num);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Número inválido. " + exc.Message);
                num = 1;
            }
        }
        while (num != 0);   
    }

    private static void EjemploTryCatchMultiple()
    {
        try
        {
            Console.Write("Escribe el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + result);
        }
        catch (FormatException exc)
        {
            Console.WriteLine("¡Número inválido!");
        }
        catch (DivideByZeroException exc)
        {
            Console.WriteLine("¡No se puede dividir por 0!");
        }
        catch (Exception exc)
        {
            Console.WriteLine("Ha ocurrido un error: " + exc.Message);
        }
        finally
        {
            Console.WriteLine("Programa finalizado");
        }
    }

    private static void EjemploThrow()
    {
        try
        {
            Console.Write("Escribe el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            int result = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + result);
        }
        catch (FormatException exc)
        {
            Console.WriteLine("¡Número inválido!");
        }
        catch (DivideByZeroException exc)
        {
            Console.WriteLine("¡No se puede dividir por 0!");
        }
    }

    private static void EjemploThrowCustomException()
    {   
        try {
            Console.Write("Escribe un número del 1 al 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 10)
            {
                throw new InvalidNumberException();
            }
            Console.WriteLine("Tu número es: " + num);
        }
        catch (FormatException exc)
        {
            Console.WriteLine("¡Formato de número inválido!");
        }
        catch (InvalidNumberException exc)
        {
            Console.WriteLine("¡Número inválido. Debe ser del 1 al 10!");
        }
    }

    public static void Main()
    {
        //EjemploTryCatch();
        //EjemploTryCatchMultiple();
        //EjemploThrow();
        EjemploThrowCustomException();
    }
}

public class InvalidNumberException : Exception
{
}
