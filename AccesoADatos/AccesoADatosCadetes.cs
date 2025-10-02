using System.Text.Json;

public class AccesoADatosCadetes
{
    private string path = "Files/cadetes.json";

    public List<Cadete> Optener()
    {
        List<Cadete> cadetes = null;
        if (!File.Exists(path))
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