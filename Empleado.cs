public enum cargos{Auxiliar,Administrativo,Ingeniero,Especialista,Investigador}
public class Empleado{
    string nombre,apellido;
    DateTime fechaNac;
    char estadoCivil;
    char genero;
    DateTime fechaIngreso;
    double sueldo;
    cargos cargo;
    public Empleado(string nombreIn,string apellidoIn,DateTime fechaNacIn,char estadoCivilIn,char generoIn,DateTime fechaIngresoIn,double sueldoIn, cargos cargoIn){
        this.nombre=nombreIn;
        this.apellido=apellidoIn;
        this.fechaNac=fechaNacIn;
        this.estadoCivil=estadoCivilIn;
        this.genero=generoIn;
        this.sueldo=sueldoIn;
        this.cargo=cargoIn;
    }
    public int antiguedad(){
        return DateTime.Now.Year-fechaIngreso.Year;
    }
    public int edad(){
        return DateTime.Now.Year-fechaNac.Year;
    }
    public int retiro(){
        if(genero=='F'){
            return 60-edad();
        }else{
            return 65-edad();
        }
    }
    public double salario(){
        double incremento=antiguedad()>20 ? incremento=sueldo*0.25:incremento=(sueldo*0.1)*20;
        if(cargo==cargos.Ingeniero || cargo==cargos.Especialista){
            incremento*=1.50;
        }
        if(estadoCivil=='C'){
            incremento+=15000;
        }
        return sueldo+incremento;
    }
    public void mostrarDatos(){
        Console.WriteLine("\nNombre: "+this.nombre);
        Console.WriteLine("\nApellido: "+this.apellido);
        Console.WriteLine("\nFecha de nacimiento: "+this.fechaNac);
        Console.WriteLine("\nEstado Civil: "+this.estadoCivil);
        Console.WriteLine("\nGenero: "+this.genero);
        Console.WriteLine("\nFecha de ingreso a la empresa: "+this.fechaIngreso);
        Console.WriteLine("\nSueldo basico: "+this.sueldo);
        Console.WriteLine("\nCargo: "+this.cargo.ToString());
        Console.WriteLine("\nAntiguedad en la empresa: "+this.antiguedad());
        Console.WriteLine("\nAnios para jubilarse: "+this.retiro());
        Console.WriteLine("\nSalario: "+this.salario());
    }
}