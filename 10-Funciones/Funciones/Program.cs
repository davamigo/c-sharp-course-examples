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

Console.WriteLine(Functions.Suma(5, 7));
Console.WriteLine(Functions.Suma(5.4, 7.8));
Console.WriteLine(Functions.Suma("xxxx", "yyyy"));

