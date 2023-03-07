namespace Tarea2_EjercicioPOO;

public class Puerta{

    public string color;

    public Puerta(){
        this.color = "Café";
    }

    public void setColor(string color){
        this.color=color;
    }

    public void mostrarDatos(){
        Console.WriteLine($"Soy una puerta, mi color es {color}");
    }

}