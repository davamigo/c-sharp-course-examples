/*
Una variable es una forma de darle un nombre a un valor

Una función es una forma de darle nombre a un trozo de código... para usarlo después

Sintaxis:

    tipo-de-retorno nombre-función ( parametro1, paremetro2, ... )
*/

// Ejemplo: Función Hola Mundo

void HolaMundo()
{
    Console.WriteLine("Hola Mundo!");
}

HolaMundo();

// Ejemplo: Función Suma Dos Numeros

void SumaDosNumeros(int num1, int num2)
{
    int suma = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + suma);
}

SumaDosNumeros(1, 5);
SumaDosNumeros(2, 7);
SumaDosNumeros(-1, -5);
SumaDosNumeros(10, 5);
SumaDosNumeros(0, 0);

for (int i = 1; i <= 5; i++)
{
    SumaDosNumeros(i, i);
}

// Ejemplo: Función WL como atajo para Console.WriteLine

void WL(string text)
{
    Console.WriteLine(text);
}

WL("Hola mundo");

int SumaDosNumerosYDevuelveResultado(int num1, int num2)
{
    int suma = num1 + num2;
    return suma;
}

int result = SumaDosNumerosYDevuelveResultado(6, 7);
WL("6 + 7 = " + result);
