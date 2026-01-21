/*
Un bucle es una acción que se repite a lo largo del tiempo.

La forma más sencilla es el bucle "while" que ejecuta un bloque de instrucciones mientras se cumpla una condición.

Sintaxis:

while (condición) {
    instrucciones;
}
*/


// Un programa que escriba por pantalla los número del 1 al 10


int num1 = 1;
while (num1 <= 10)
{
    Console.WriteLine(num1);
    num1++;
}

/*
Otro tipo de bucle es el bucle "do-while"

Sintaxis:

do {
    instrucciones;
}
while (condición);
*/

int num2 = 1;
do
{
    Console.WriteLine(num2);
    num2++;
}
while (num2 <= 10);
