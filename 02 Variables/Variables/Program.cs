/*
Números binarios en un byte

00000000 = 0
00000001 = 1
00000010 = 2
00000011 = 3
00000100 = 4
00000101 = 5
00000110 = 6
00000111 = 7
00001000 = 8
00001001 = 9
00001010 = 10
00001011 = 11
...
11111100 = 252
11111101 = 253
11111110 = 254
11111111 = 255
*/

/* Tipos de datos */

byte theByte = 128; // Número de 0 a 255 (un byte está formado por 8 bits)
short theShort = 567; // Número de 2 bytes (16 bits)
int theInteger = 123456677; // Número de 4 bytes (32 bits)

float theFloat = 0.45F; // Número real (baja precición). Ej: 0.45.
double theDouble = -101.67; // Número real (alta precisión).

string name = "Elsa";

int age;
age = 21;

Console.WriteLine("Te llamas " + name);
Console.WriteLine("Tu edad es " + age);

/*
Los nombre de variable suelen estar en inglés y ser camel case
Ejemplo: int thisIsCamelCase;
*/

age = age + 1; // esto es igual que: age++;

Console.WriteLine("Tu edad ahora es " + age);

/*
Operadores => sirven para hacer operaciones matemáticas
Tipos de operadores
    +   sumar
    -   restar
    *   multiplicar
    /   dividir
    %   resto de la división
    ++  incremento
    --  decremento
*/

int sumResult = 10 + 5;
int divisionResult = 11 / 3;
int moduleResult = 11 % 3;
double realDivisionResult = 11.0 / 3;

Console.WriteLine("El resultado de la suma es " + sumResult);
Console.WriteLine("El resultado de la división es " + divisionResult);
Console.WriteLine("El resto de la división es " + moduleResult);
Console.WriteLine("El resultado de la división real es " + realDivisionResult);
