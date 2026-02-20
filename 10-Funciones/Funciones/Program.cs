///////////////////////////////////////////////////////////////////////////////////////////////////
// Una variable es una forma de darle un nombre a un valor
//
// Una función es una forma de darle nombre a un "trozo de código"... para usarlo después
//
// Sintaxis:
//   tipo-de-retorno nombre-función ( tipo1 parámetro1, tipo2 parámetro2, ... )
//
// Ejemplo: Función Hola Mundo

// Definición de la función
void HolaMundo()
{
    Console.WriteLine("Hola Mundo!");
}

// Llamada a la función
HolaMundo();



///////////////////////////////////////////////////////////////////////////////////////////////////
// Ejemplo: Función Suma Dos Numeros

// Definición de la función
void SumaDosNumeros(int num1, int num2)
{
    int suma = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + suma);
}

// Llamadas a la función
SumaDosNumeros(1, 5);
SumaDosNumeros(2, 7);
SumaDosNumeros(-1, -5);
SumaDosNumeros(10, 5);
SumaDosNumeros(0, 0);

for (int i = 1; i <= 5; i++)
{
    SumaDosNumeros(i, i);
}



///////////////////////////////////////////////////////////////////////////////////////////////////
// Ejemplo: Función WL como atajo para Console.WriteLine

void WL(string text)
{
    Console.WriteLine(text);
}

WL("Hola mundo");



///////////////////////////////////////////////////////////////////////////////////////////////////
// El nombre de la función tienen que explicar lo que hace

int SumaDosNumerosYDevuelveResultado(int num1, int num2)
{
    int suma = num1 + num2;
    return suma;
}

int result = SumaDosNumerosYDevuelveResultado(6, 7);
WL("6 + 7 = " + result);



///////////////////////////////////////////////////////////////////////////////////////////////////
// Funciones dentro de funciones

int varGlobal = 0;
void bisabuelo()
{
    int varBisabuelo = varGlobal + 1;
    WL("Dentro de bisabuelo " + varBisabuelo);
    abuelo();

    void abuelo()
    {
        int varAbuelo = varBisabuelo + 1;
        WL("Dentro de abuelo " + varAbuelo);
        padre();

        void padre()
        {
            int varPadre = varAbuelo + 1;
            WL("Dentro de padre " + varPadre);
            hijo();

            void hijo()
            {
                int varHijo = varPadre + 1;
                WL("Dentro de hijo " + varHijo);
            }
        }
    }
}

bisabuelo();



///////////////////////////////////////////////////////////////////////////////////////////////////
// Sobrecarga de funciones
//
// Las funciones sobrecargadas tienen el mismo nombre pero distintos parámetros
//
// Ver la clase Functions (en otro fichero)
//
// El compilador decide a que función llamar dependiendo de los parámetros que se pasen
//

Console.WriteLine(Functions.Suma(5, 7));            // Llama a Suma(int, int)
Console.WriteLine(Functions.Suma(5.4, 7.8));        // Llama a Suma(double, double)
Console.WriteLine(Functions.Suma(5, 7.8));          // Llama a Suma(double, double)
Console.WriteLine(Functions.Suma("xxxx", "yyyy"));  // Llama a Suma(string, string)



///////////////////////////////////////////////////////////////////////////////////////////////////
// Funciones anidadas
//
// Son funciones dentro de funciones
//

int Calculadora(int valor1, int valor2, int operacion)
{
    // Esta es la funcion más exterior

    int Suma(int valor1, int valor2)
    {
        return valor1 + valor2;
    }

    int Resta(int valor1, int valor2)
    {
        return valor1 - valor2;
    }

    int Mult(int valor1, int valor2)
    {
        return valor1 * valor2;
    }

    switch (operacion)
    {
        case 1:
            return Suma(valor1, valor2);
        case 2:
            return Resta(valor1, valor2);
        case 3:
            return Mult(valor1, valor2);
        default:
            return 0;
    }
}

// Desde fuera de la función se puede llamar a Calculadora().
// Pero no se puede llamar a Suma() o Resta() o Mult() porque no existen fuera de Calculadora().
int num = Calculadora(10, 5, 1);



///////////////////////////////////////////////////////////////////////////////////////////////////
// Paso de parámetros por referencia
//

void Suma2 (int num)
{
    num = num + 2;
}

void Suma2Ref (ref int num)
{
    num = num + 2;
}

int x = 23;
Suma2(x);
Console.WriteLine("El resultado es: " + x);

Suma2Ref(ref x);
Console.WriteLine("El resultado es: " + x);



///////////////////////////////////////////////////////////////////////////////////////////////////
// Variables globales y locales
//
// Las variables globales existen en todo el contexto
//
// Las variables locales sólo existen dentro de un bloque {} (como una función)
//

// La variable g es una variable global
int g = 37;

if (g < 56)
{
    // La variable l es una variable local que sólo existe entro de las llaves {}
    int l = g + 1;
    Console.WriteLine(l);

    // Justo aquí la variable l se detruye, pero g sigue existiendo
}

// No puedo llamar a l aquí porque ya no existe
//Console.WriteLine(l);



///////////////////////////////////////////////////////////////////////////////////////////////////
// Parámetros opcionales
//
// Un parámetro opcional de una función es el valor por defecto que tensdrá cuando se llama a
// la función sin parámetrod

int Potencia (int num, int pot = 2)
{
    int resultado = num;
    for (int i = 1; i < pot; i++)
    {
        resultado *= num;
    }
    return resultado;
}

int resultado = Potencia(2, 3);
Console.WriteLine("Pot 2^3=" + resultado);

Console.WriteLine("Pot 4=" + Potencia(4));
