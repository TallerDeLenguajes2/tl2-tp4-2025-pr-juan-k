using System.Text.Json;

public class AccesoADatosCadetes
{
    private string path = "File/cadetes.json";

    public List<Cadete> Obtener()
    {
        List<Cadete> cadetes = null;
        if (File.Exists(path))
        {
            string jsonTX = File.ReadAllText(path);
            cadetes = JsonSerializer.Deserialize<List<Cadete>>(jsonTX);
            return cadetes;
        }else
        {
            return cadetes;
        }
    } 
}