using System.Text.Json.Serialization;


public enum EstadoPedido
{
    Pendiente,  // (Valor 0)
    Asignado,   // (Valor 1)
    EnCamino,   // (Valor 2)
    Entregado,  // (Valor 3)
    Cancelado   // (Valor 4)
}
public class Pedido
{
    private int nro = 0;
    private string? observacion;
    //public Cliente cliente;
    private EstadoPedido estado;

    public int Nro { get => nro; set => nro = value; }
    public string? Observacion { get => observacion; set => observacion = value; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EstadoPedido Estado { get; set; } 
}