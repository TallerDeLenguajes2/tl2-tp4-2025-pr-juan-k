using System.Text.Json;

public class AccesoADatosCadeteria
{
    private string path = "Files/cadeteria.json";

    public Cadeteria Obtener()
    {
        Cadeteria cadeteria = null;
        if (!File.Exists(path))
        {
            return cadeteria;
        }
        else
        {
            var jsonTX = File.ReadAllText(path);
            cadeteria = JsonSerializer.Deserialize<Cadeteria>(jsonTX);
            return cadeteria;
        }
    }

}