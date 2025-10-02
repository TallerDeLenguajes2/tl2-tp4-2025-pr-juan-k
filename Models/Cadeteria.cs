public class Cadeteria
{
    private string? nombre;
    private int telefono;
    //lista de Cadetes
    private List<Cadete>? cadetes;
    private List<Pedido>? pedidos;
    public Cadeteria()
    {
        Cadetes = new List<Cadete>();
        Pedidos = new List<Pedido>();
    }
    public string? Nombre { get; set; }
    public int Telefono { get; set; }
    public List<Cadete>? Cadetes { get => cadetes; set => cadetes = value; }
    public List<Pedido>? Pedidos { get => pedidos; set => pedidos = value; }

    public void AgregarListaCadetes(List<Cadete> cadeteP)
    {
        Cadetes = cadeteP;
    }
    public void AgregarListaPedidos(List<Pedido> pedidosP)
    {
        Pedidos = pedidosP;
    }
     
}
