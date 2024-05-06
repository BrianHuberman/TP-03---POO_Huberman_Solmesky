namespace TP_03___POO_Huberman_Solmesky;
class Program
{
    static void Main(string[] args)
    {
        int idEntrada, ultimoID, dni, tipoEntrada, cantidad;
        string nombre, apellido;
        double fechaInscrpcion;
        dni = ingresarInt("Ingrese su DNI");
        tipoEntrada = ingresarInt("Ingrese el tipo de entrada");
        cantidad = ingresarInt("Ingrese la cantidad");
        nombre= ingresarCadena("Ingrese su nombre");
        apellido= ingresarCadena("Ingrese su apellido");
        fechaInscrpcion= ingresarDouble("Ingrese la fechs de inscripcion");

        Cliente cliente = new Cliente(dni, apellido, nombre, fechaInscrpcion, tipoEntrada, cantidad);

        ultimoID = Ticketera.DevolverUltimoId(idEntrada);
    }
    static int ingresarInt(string m)
    {
        int r;
        Console.WriteLine(m);
        r= int.Parse(Console.ReadLine());
        return r;
    }
      static string ingresarCadena(string m)
    {
        string r;
        Console.WriteLine(m);
        r=Console.ReadLine();
        return r;
    }
      static int ingresarDouble(string m)
    {
        double r;
        Console.WriteLine(m);
        r= double.Parse(Console.ReadLine());
        return r;
    }

    
}
