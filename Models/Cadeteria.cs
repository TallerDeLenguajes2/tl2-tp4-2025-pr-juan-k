public class Cadeteria
{
    private string? nombre;
    private int telefono;
    //lista de Cadetes
    private List<Cadete>? cadetes;
    private List<Pedido>? pedidos;
    public Cadeteria()
    {
        cadetes = new List<Cadete>();
        pedidos = new List<Pedido>();
    }
    public string? Nombre { get; set; }
    public int Telefono { get; set; }
    public void AgregarListaCadetes(List<Cadete> cadeteP)
    {
        cadetes = cadeteP;
    }
    public void AgregarListaPedidos(List<Pedido> pedidosP)
    {
        pedidos = pedidosP;
    }
     
}
