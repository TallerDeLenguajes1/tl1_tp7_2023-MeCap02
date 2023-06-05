using EspacioCalculadora;

Calculadora cal=new Calculadora();
int aux=1;
string? num;
double temp;


while(aux!=0){
    Console.WriteLine("\n---MENU---");
    Console.WriteLine("\n1=Sumar\n2=Restar\n3=Multiplicar\n4=Dividir\n5=Reiniciar Valor");
    string? extra=Console.ReadLine();
    while(!int.TryParse(extra,out aux)){
        Console.WriteLine("\nIngrese un numero correcto");
        extra=Console.ReadLine();
    }
    Console.WriteLine("Ingrese un numero");
    num=Console.ReadLine();
    while(!double.TryParse(num,out temp)){
        Console.WriteLine("\nIngrese un numero valido\n");
        num=Console.ReadLine();
    }
    switch(aux){
        case 1:
            cal.sumar(temp);
            break;
        case 2:
            cal.restar(temp);
            break;
        case 3:
            cal.multiplicar(temp);
            break;
        case 4:
            cal.dividir(temp);
            break;
        case 5:
            cal.limpiar();
            break;
        default:
            break;
    }
    Console.WriteLine("\nResultado guardado:"+cal.Resultado);
    Console.WriteLine("\nDesea continuar?\n0=Salir\n1=Continuar");
    extra=Console.ReadLine();
    while(!int.TryParse(extra,out aux)){
        Console.WriteLine("\nIngrese un numero correcto");
        extra=Console.ReadLine();
    }
}