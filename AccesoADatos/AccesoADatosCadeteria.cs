using System.Text.Json;
using System.IO;

public class AccesoADatosCadeteria
{
    private string path = "File/cadeteria.json";

    public Cadeteria Obtener()
    {
        // Verifica si el archivo existe
        if (File.Exists(path))
        {
            var jsonTX = File.ReadAllText(path);

            // Asegura que el contenido no esté vacío antes de deserializar
            if (!string.IsNullOrWhiteSpace(jsonTX))
            {
                // Intenta deserializar. Si falla o es null, el operador ?? se encarga.
                // Es recomendable añadir opciones si tu Cadeteria usa listas inicializadas.
                var cadeteria = JsonSerializer.Deserialize<Cadeteria>(jsonTX);
                
                // Si la deserialización fue exitosa, la devuelve; si no, devuelve una nueva instancia.
                return cadeteria ?? new Cadeteria();
            }
        }
        
        // Si el archivo no existe o el JSON estaba vacío, devuelve una nueva instancia.
        return new Cadeteria();
    }
}