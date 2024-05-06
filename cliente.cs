class Cliente
{
    public int DNI{get; private set;}
    public string Apellido{get; private set;}
    public string Nombre{get; private set;}
    public double FechaInscrpcion{get;set;}
    public int TipoEntrada{get;set;}
    public int Cantidad{get;set;}
    
    public Cliente(int dni, string apellido, string nombre, double fecha, int tipoentrada, int cantidad){
        DNI = dni;
        Apellido = apellido;
        Nombre = nombre;
        FechaInscrpcion = fecha;
        TipoEntrada = tipoentrada;
        Cantidad = cantidad;
    }

}