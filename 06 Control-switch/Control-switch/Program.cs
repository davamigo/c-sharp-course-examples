/*
Estructuras de control

    - if
    - operador ?
    - switch case
*/

Console.Write("¿Qué nota has sacado? ");
int grade = Convert.ToInt32(Console.ReadLine());

string result;
switch (grade)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
        result = "suspendido";
        break;
    case 5:
    case 6:
        result = "aprobado";
        break;
    case 7:
    case 8:
        result = "notable";
        break;
    case 9:
    case 10:
        result = "excelente";
        break;
    default:
        result = "nota erronea";
        break;
}
Console.WriteLine("Tu nota es: " + result);

///////

string result2 = grade switch
{
    0 or 1 or 2 or 3 or 4 => "suspendido",
    5 or 6 => "aprobado",
    7 or 8 => "notable",
    9 or 10 => "excelente",
    _ => "nota erronea",
};
Console.WriteLine("Tu nota es: " + result2);

///////

/*
Sintaxis switch-case:

    switch (variable)
    {
        case valor1:
            sentencia1;
            sentencia2;
            break;

        case valor2:
            sentencia3;
            break;

        case ...
            break;

        default:
            sentencia-por-defecto;
            break;
    }
*/
