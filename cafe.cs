int precio = 1000;
string cafe = "Cafe: ";

Console.WriteLine("¡¡¡ Venta de café !!!");
Console.Write("Seleccione el tamaño: 1: 6oz | 2: 10oz: ");
int tamano = int.Parse(Console.ReadLine());

if(tamano == 1) {
    cafe += "tamaño de 6oz";
    precio += 1000;
} else {
    cafe += "tamaño de 10oz";
    precio += 1500;
}

Console.WriteLine();

Console.Write("¿Con azucar? S: si | N: No : ");

char azucar = char.Parse(Console.ReadLine());

if (azucar == 'S') {
    precio += 300;
    cafe += ", con azucar";
} else {
    cafe += ", sin azucar";
}

Console.WriteLine();

Console.Write("¿Con leche? S: si | N: No : ");

string leche = Console.ReadLine();

if (leche == "S") {
    cafe += ", con leche";
    precio += 500;
} else {
    cafe += ", sin leche";
}

Console.WriteLine();

Console.Write("¿Con Licor? R: Rom | A: Amaretto | W: Whiskey | N: No : ");

string licor = Console.ReadLine();

switch(licor){
    case "R":
            cafe += " y ron.";
            precio += 1000;
    break;
    case "A":
            cafe += " y amaretto.";
            precio += 1500;
    break;
    case "W":
            cafe += " y whiskey.";
            precio += 2000;
    break;
    default:
            cafe += " sin licor.";
    break;
}

Console.WriteLine($"{cafe} Valor: ${precio}");
