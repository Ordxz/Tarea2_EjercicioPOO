namespace Tarea2_EjercicioPOO;

public class Persona{
    public string nombre;

    public Casa casa;

    public Persona(){
        this.nombre = "Juan";
        this.casa= new Casa(150);
    }

    public Persona(string nombre, Casa casa){
        this.nombre=nombre;
        this.casa = casa;

    }

    public void setNombre(string nombre){
        this.nombre=nombre;
    }
    public void setCasa(Casa casa){
        this.casa=casa;
    }
    public void mostrarDatos(){
        Console.WriteLine($"Mi nombre es {nombre}");
        casa.mostrarDatos();
        casa.puerta.mostrarDatos();

    }
}