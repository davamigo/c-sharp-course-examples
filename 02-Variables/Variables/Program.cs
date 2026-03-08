/*
VARIABLES

Una variable es una zona de memoria del ordenador que se utiliza para almacenar un dato.
Una variable tiene nombre, un tipo de datos y un valor.
Su contenido puede cambiar durante la ejecución del programa.

Definición de una variable:
    tipoDatos nombreVariable;

Definición con inicialización:
    tipoDatos nombreVariable = valorInicial;

Asignación de valor (posterior a la inicialización):
    nombreVariable = nuevoValor;


Los nombre de variable suelen estar en inglés y ser camel case.

Estilos de variables:
    - thisIsCamelCase
    - ThissPascalCase
    - this_is_snake_case

Ejemplo:
    int thisIsCamelCase;


Tipos de datos

Un tipo de datos determina qué tipo de valor puede almacenar una variable.
El tipo de datos define el formato del valor (número, texto, etc.) y las operaciones que se pueden realizar con él.

Los ordenadores sólo entienden números binarios.
Un bit es un dígito binario: o bien un 0 o bien un 1.

Los ordenadores almacenan internamente la información en bytes.
Un byte es un número de 8 bits.
Por lo tanto un byte puede almacenar sólo 256 valores (2^8)
Un tipo de datos numérico puede constar de varios bytes.
*/

// Números enteros de 1 byte (8 bites)
using System.Reflection.Metadata.Ecma335;

byte unsignedByte = 128; // 0..255
sbyte signedByte = -60;  // -128..0..127

// Números enteros de 2 bytes (16 bits)
short signedShort = -1011; // -32768..0..32767
ushort unsignedShort = 567; // 0..65535

// Números enteros de 4 bytes (32 bits)
int signedInteger = -700000;
uint unsignedInteger = 123456677;

// Números enteros de 8 bytes (64 bits)
long signedLong = -7000000000000000;
ulong unsignedLong = 8000000000000000;

// Números reales
float floatNum = 0.45F;         // Baja precisión
double doubleNum = -101.67;     // Alta precisión
decimal decimalNum = 987.654M;  // Mejor precisión

// Booleanos: Sólo true o false
bool boolValue = true; 

// Texto: Caracter simple
char symbol = 'F';

// Texto: cadena de caracteres
string text = "loren ipsum";

// Arrays - variables con múltiples valores
int[] numArray = [1, 2, 3, 4];
string[] stringArray = [
    "Loren",
    "Ipsum"
];

// objects ---> lo veremos más adelante

/*
Ejemplo:
*/

string name = "Elsa";
int age;
age = 21;

Console.WriteLine("Te llamas " + name);
Console.WriteLine("Tu edad es " + age);

age++; // esto es igual que: age = age + 1;

Console.WriteLine("Tu edad ahora es " + age);

/*
conversión de tipos
*/

double dbl = 1.23;
int num = (int) dbl;

Console.WriteLine("el valor " + dbl + " convertido a entero es: " + num);

/*
Ámbito de variables
*/

// Esto es una variable global.
int globalVar = 33;

// Esto es un bloque de código.
{
    // Esto es una variable local.
    int localVar = 81;

	// Aquí se puede acceder a globalVar.
   localVar += globalVar;

    Console.WriteLine(localVar);
}

// Aquí ya no se puede acceder a localVar porque se ha destruido.
Console.WriteLine(globalVar);
