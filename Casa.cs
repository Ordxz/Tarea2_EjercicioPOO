namespace Tarea2_EjercicioPOO;

public class Casa{
    public int area;
    public Puerta puerta = new Puerta();

    public Casa(int area)
    {
        this.area = area;
        this.puerta=new Puerta();
    }

    public void setArea(int area){
        this.area=area;
    }

    public void setPuerta(Puerta puerta){
        this.puerta=puerta;
    }

    public virtual void mostrarDatos(){
        Console.WriteLine($"Soy una casa, mi area es {area} m2");
    }

}