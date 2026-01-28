// Ejemplo array de enteros
int[] enteros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int entero = enteros[0];
Console.WriteLine(entero); // Escribirá un 1


// Otra forma de crear un array
int[] enteros2 = new int[7]; // [0, 0, 0, 0, 0, 0, 0]
Console.WriteLine(enteros2[0]);


// Un string es un array de caracteres
string holaMundo = "Hola Mundo";
char c = holaMundo[5];
Console.WriteLine(c); // Escribirá M

// Podemos ver el valor numérico del caracter M
byte b = (byte) c;
Console.WriteLine(b); // Escribirá 77 porque el valor ascii de la letra M es 77


// Ejemplo foreach con un string
Console.WriteLine(holaMundo);
foreach(char letra in holaMundo)
{
    Console.WriteLine(letra);
}

// Lo mismo, pero con un bucle for
for (int i = 0; i < holaMundo.Length; i++)
{
    char letra = holaMundo[i];
    Console.WriteLine(letra);
}

// Ejemplo foreach con un int[]
foreach(int num in enteros)
{
    Console.WriteLine(num);
}

/*
Syntaxis:

    foreach (tipo nombreVar in arrayOString)
    {
        // nombreVar --> tiene cada valor del array
    }
*/