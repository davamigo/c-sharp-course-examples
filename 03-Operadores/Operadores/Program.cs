
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


/*
Prioridad de operaciones
- Parentesis
- Negación
- Multiplicaciones y Divisiones
- Resto
*/

int result = (1 + 2 * 3) / 4 - 5;

Console.WriteLine("El resultado es " + result); // -4


/*
Overflow
*/

byte b = 255; // Unsigned
b++;

// El resultado es 0 porque hace overflow
Console.WriteLine("El byte con overflow es " + b);


short s = 32767; // Signed -32768..0..32767
s++;

// El resultado es -32768 porque hace overflow
Console.WriteLine("El short con overflow es " + s);

// 32767 en binario es: 01111111 1111111 + 1 = 1000000 00000000 (-32768)


int i = 2147483647;
i++;

Console.WriteLine("El int con overflow es " + i);


