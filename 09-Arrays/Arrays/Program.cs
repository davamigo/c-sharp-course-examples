/*
Array:
    Es un tipo de datos que puede guardar varios valores del mismo tipo.
    Ejemplo: lista de numeros, lista de personas, etc.

Sintaxis:
    tipoDeDatos[] nombreVariable;

    tipoDeDatos[] nombreVariable = new tipoDeDatos[numeroDeElementos];

    tipoDeDatos[] nombreVariable = [ valor1, valor2, ..., valor_n ];
*/

// Ejemplo array de enteros
int[] enteros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int entero = enteros[0];
Console.WriteLine("enteros[0]=" + entero); // Escribirá un 1


// Otra forma de crear un array
int[] enteros2 = new int[7]; // [0, 0, 0, 0, 0, 0, 0]
Console.WriteLine("enteros2[0]=" + enteros2[0]);


// Un string es un array de caracteres
string holaMundo = "Hola Mundo";
char c = holaMundo[5];
Console.WriteLine("Letra: " + c); // Escribirá M

// Podemos ver el valor numérico del caracter M
byte b = (byte) c;
Console.WriteLine("Valor: " + b); // Escribirá 77 porque el valor ascii de la letra M es 77

/*
foreach
    es un tipo de bucle para recorrer arrays

Syntaxis:

    foreach (tipo nombreVar in arrayOString)
    {
        // nombreVar --> tiene cada valor del array
    }
*/

// Ejemplo foreach con un string
Console.WriteLine("\n" + holaMundo);
foreach(char letra in holaMundo)
{
    Console.WriteLine(letra);
}

// Lo mismo, pero con un bucle for
Console.WriteLine("\n" + holaMundo);
for (int i = 0; i < holaMundo.Length; i++)
{
    char letra = holaMundo[i];
    Console.WriteLine(letra);
}

Console.WriteLine("\n" + "enteros:");
// Ejemplo foreach con un int[]
foreach(int num in enteros)
{
    Console.WriteLine(num);
}

/*
Matrices:
    Es un tipo especial de array que permite almacenar los valores en forma de tabla.

Sintaxis:
    tipoDeDatos[,] nombreVariable;

    tipoDeDatos[,] nombreVariable = new tipoDeDatos[numeroDeFiles, numeroDeColumnas];

    tipoDeDatos[,] nombreVariable = [ [ valorF0C0, valorF0C1, ... ], ... ];
*/

// Ejemplo de matriz de interos
int[,] matrix = new int[4, 5];

Console.WriteLine("\nMatrix:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

/*
Arrays de arrays:
*/

int[][] arrayOfArrays = [ [ 1, 2, 3 ], [ 4, 5 ], [ 6, 7, 8, 9, ], [ 10 ] ];

Console.WriteLine("\nArray of array:");
for (int i = 0; i < arrayOfArrays.Length; i++)
{
    for (int j = 0; j < arrayOfArrays[i].Length; j++)
    {
        Console.Write(arrayOfArrays[i][j] + " ");
    }
    Console.WriteLine();
}