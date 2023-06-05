namespace EspacioCalculadora{
//ignorar
public class Calculadora{
    private double dato=0;
    public Calculadora()=>dato=0;
    public void sumar(double numero)=>dato+=numero;
    public void restar(double numero)=>dato-=numero;
    public void multiplicar(double numero)=>dato*=numero;
    public void dividir(double numero){
        if(numero==0){
            Console.WriteLine("\nSe intento dividir en cero");
            return;
        }else{
            dato/=numero;
        }
    }
    public void limpiar()=>dato=0;
    public double Resultado{
        get=>dato;
    }
}
}