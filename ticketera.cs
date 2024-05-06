static class Ticketera
{
    private Dictionary<int,Cliente> DicCliente = new Dictionary<int,Cliente>();
    private int UltimoIdEntrada{get;set;} = 0;
    
    public int DevolverUltimoId()
    {
        return UltimoIdEntrada;
    }

    public int AgregarCliente(Cliente cliente)
    {
        UltimoIdEntrada++;
        DicCliente.Add(UltimoIdEntrada, cliente);
        return UltimoIdEntrada;
    }

    public Cliente BuscarCliente(int id)
    {
        Cliente infoCliente;
        if(DicCliente.ContainsKey(id))
        {
            infoCliente = DicCliente[id];
        }
        else 
        {
            infoCliente = null;
        }
        
        return infoCliente;
    }
    public int CambiarEntrada(int id, int tipo, int cantidad)
    {
        
    }
    public List <string> estadisticasTicketera()
    {

    } 


}