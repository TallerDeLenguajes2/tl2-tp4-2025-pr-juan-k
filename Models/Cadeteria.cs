public class Cadeteria
{
    private string? nombre;
    private int telefono;
    //lista de Cadetes

    public Cadeteria()
    {
        Cadetes = new List<Cadete>();
        Pedidos = new List<Pedido>();
    }
    public string? Nombre { get; set; }
    public int Telefono { get; set; }
public List<Cadete> Cadetes { get; set; } = new List<Cadete>();
    public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    public void AgregarListaCadetes(List<Cadete> cadeteP)
    {
        Cadetes = cadeteP;
    }
    public void AgregarListaPedidos(List<Pedido> pedidosP)
    {
        Pedidos = pedidosP;
    }
     
}
