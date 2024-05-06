static class Ticketera
{
    private Dictionary<int,Cliente> DicCliente = new Dictionary<int,Cliente>();
    private int UltimoIdEntrada{get;set;} = 0;
    
    public int DevolverUltimoId(int idEntradaUltimo)
    {
        UltimoIdEntrada = idEntradaUltimo;
        return UltimoIdEntrada;
    }

    public int AgregarCliente(Cliente cliente)
    {
        DicCliente.Add(cliente);
        return UltimoIdEntrada;
    }

    public Cliente BuscarCliente(int id)
    {

    }
    public int CambiarEntrada(int id, int tipo, int cantidad)
    {

    }
    public List <string> estadisticasTicketera()
    {

    } 


}