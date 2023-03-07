namespace Tarea2_EjercicioPOO;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.mostrarDatos();
        persona.nombre = "Christian Ordaz";
        Apartamento nuevoApartamento = new Apartamento();
        Puerta nuevaPuerta = new Puerta();
        nuevaPuerta.setColor("Verde");
        nuevoApartamento.setPuerta(nuevaPuerta);
        persona.setCasa(nuevoApartamento);
        persona.mostrarDatos();
        }
}
