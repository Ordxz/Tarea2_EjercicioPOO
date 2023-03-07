namespace Tarea2_EjercicioPOO;

public class Apartamento : Casa{

    public Apartamento() : base(50){

    }
    override public void mostrarDatos(){
        Console.WriteLine($"Soy un Apartamento, mi area es {area} m2");
    } 
}