Empleado primerEmpleado=new Empleado("Pedro","Gimenez",new DateTime(1987,05,24),'S','M',new DateTime(2011,07,11),150000,cargos.Auxiliar);
Empleado segundEmpleado=new Empleado("Maria","Ortiz",new DateTime(1991,02,28),'C','F',new DateTime(2014,04,28),200000,cargos.Especialista);
Empleado tercerEmpleado=new Empleado("Jorge","Ibanez",new DateTime(1993,06,17),'C','M',new DateTime(2014,07,30),150000,cargos.Ingeniero);
Empleado[] empleados={primerEmpleado,segundEmpleado,tercerEmpleado};
Empleado empleadoViejo=primerEmpleado;
Console.WriteLine("\nSalario total de los empleados: "+(primerEmpleado.salario() + segundEmpleado.salario() + tercerEmpleado.salario()));
foreach(Empleado empleado in empleados){
    if(empleado.salario() < empleadoViejo.retiro()){
        empleadoViejo=empleado;
    }
}
Console.WriteLine("\nInformacion del empleado mas viejo\n");
empleadoViejo.mostrarDatos();