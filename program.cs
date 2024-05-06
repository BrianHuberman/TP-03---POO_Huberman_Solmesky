namespace TP_03___POO_Huberman_Solmesky;
class Program
{
    static void Main(string[] args)
    {   
        const int OPCION1 =45000, OPCION2 =60000,OPCION3 =30000,OPCION4 =100000;
        int dni, tipoEntrada, cantidad;
        string nombre, apellido;
        double fechaInscrpcion;
        Cliente cliente = new Cliente(dni, apellido, nombre, fechaInscrpcion, tipoEntrada, cantidad);
        cliente = Ticketera.AgregarCliente(cliente);
         switch(opcionElegida)
        {
            case 1:
            dni = ingresarInt("Ingrese su DNI");
            tipoEntrada = ValidarTipoDeEntrada("Ingrese el tipo de entrada");
            cantidad = ingresarInt("Ingrese la cantidad");
            nombre= ingresarCadena("Ingrese su nombre");
            apellido= ingresarCadena("Ingrese su apellido");
            fechaInscrpcion= ingresarDouble("Ingrese la fecha de inscripcion");
            tipoEntrada = tipoEntrada(OPCION1, OPCION2, OPCION3, OPCION4, tipoEntrada);
                 break;
            case 2:
                 break;
            case 3:
                 break;
            case 4:
                 break;
            case 5:
                 break;

        }
    }
    static int TipoEntrada(int opcion1,int opcion2,int opcion3,int opcion4, int tipoDeEntrada)
    {
       int r;
        switch (tipoDeEntrada)
        {
             case 1:
                r = opcion1;
                break;
             case 2:
             r = opcion2;
                break;
             case 3:
             r = opcion3;
                break;
            case 4:
            r = opcion4;
                break;
        }
        return r;
    }
    static int ValidarTipoDeEntrada(string m)
    {
        int tipoDeEntrada, r;
        do
        {
            console.WriteLine(m);
            tipoDeEntrada= int.Parse(Console.ReadLine());
        }while(tipoDeEntrada != 1 && tipoDeEntrada != 2 && tipoDeEntrada != 3 && tipoDeEntrada != 4);
    }
       
    static int ingresarInt(string m)
    {
        int r;
        do
        {
        Console.WriteLine(m);
        r= int.Parse(Console.ReadLine());
        }while(r<0);
        return r;
    }
      static string ingresarCadena(string m)
    {
        string r;
        do
        {
        Console.WriteLine(m);
        r=Console.ReadLine();
        }while(r != string.Empty);
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

    

