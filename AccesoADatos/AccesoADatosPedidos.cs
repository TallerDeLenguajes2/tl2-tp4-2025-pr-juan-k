using System.Text.Json;

public class AccesoADatosPedidos
{
    private string path = "File";
    private string nombreArch = "pedidos.json";

    public List<Pedido> Optener()
    {
        List<Pedido> pedidos = null;
        if (!File.Exists(Path.Combine(path, nombreArch)))
        {
            string jsonTX = File.ReadAllText(Path.Combine(path, nombreArch));
            pedidos = JsonSerializer.Deserialize<List<Pedido>>(Path.Combine(path, nombreArch));
            return pedidos;
        }else
        {
            return pedidos;
        }
    }
}