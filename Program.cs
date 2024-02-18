
//Edgar Chinchilla

int evariable = int.Parse("5");

if (evariable < 0)
{
    Console.WriteLine("El numero es negativo");
}
else if (evariable > 0)
{
    Console.WriteLine("El numero es pisitivo.");
}
else
{
    Console.WriteLine("El numero es cero");
}

//==================================================

int edad = int.Parse("18");

if (edad >= 17)
{
    Console.WriteLine("Entre");
}
else
{
    Console.WriteLine("NO PUEDE ENTRAR");
}

//====================================================

int ano = int.Parse("1998");

if (ano >= 1928 && ano <= 1945)
{
    Console.WriteLine("Usted pertebece a la generación silenciona.");
}
else if (ano >= 1946 && ano <= 1964)
{
    Console.WriteLine("Usted pertenece a la generación de los Baby Boomers.");
}
else if (ano >= 1965 && ano <= 1980)
{
    Console.WriteLine("Usted pertenece a la generación de los Baby Boomers.");
}
else if (ano >= 1981 && ano <= 1996)
{
    Console.WriteLine("Usted pertenece a la generación de los millennial.");
}
else if (ano >= 1997 && ano <= 2012)
{
    Console.WriteLine("Usted pertenece a la generación Z.");
}
else if (ano >= 2013)
{
    Console.WriteLine("Usted pertenece a la generación de los Alfa.");
}
else
{
    Console.WriteLine("Año imbalido");
}

//===================================================================

switch (ano)
{
    case >= 1928 and <= 1945:
        Console.WriteLine("Usted pertebece a la generación silenciona.");
        break;

    case >= 1946 and <= 1964:
        Console.WriteLine("Usted pertenece a la generación de los Baby Boomers.");
        break;

    case >= 1965 and <= 1980:
        Console.WriteLine("Usted pertenece a la generación de los Baby Boomers.");
        break;

    case >= 1981 and <= 1996:
        Console.WriteLine("Usted pertenece a la generación de los millennial.");
        break;

    case >= 1997 and <= 2012:
        Console.WriteLine("Usted pertenece a la generación Z.");
        break;

    case >= 2013:

        Console.WriteLine("Usted pertenece a la generación de los Alfa.");
        break;

    default:
        Console.WriteLine("Año imbalido");
        break;
}
//================================================================================

// Inicio:

string nombre, pais;
int eedad;
char genero;

Console.WriteLine("Ingrese el nombre ");
nombre = Console.ReadLine().ToUpper();
Console.WriteLine("Ingrese pais:");
pais = Console.ReadLine();
Console.WriteLine("Ingrese la edad:");
eedad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese genero: M o F");
genero = char.Parse(Console.ReadLine().ToUpper());

if (!nombre.StartsWith("A") && (eedad <= 18 || genero == 'M') && (pais == "MEXICO"))
{
    Console.WriteLine("Ud. Cumple con los requisitos.");
}
else
{
    Console.WriteLine("no admitido");
}



//===============================================================================

// Si hay que llenarlo si el tanque está al 50% y la distancia es de 200
// no se puede si porcentaje de gas es <50 y la distancia es > 200

