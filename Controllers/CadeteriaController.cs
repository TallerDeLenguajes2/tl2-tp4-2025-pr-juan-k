using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[Controller]")]
public class CadeteriaController : ControllerBase
{
    private Cadeteria cadeteria; // cadeteria PRINCIPAL
    private AccesoADatosCadeteria ADCadeteria;
    private AccesoADatosCadetes ADCadete;
    private AccesoADatosPedidos ADPedidos;

    public CadeteriaController()
    {
        
        ADPedidos = new AccesoADatosPedidos();

        
    }
    /// <summary>
    /// Optenemos lista de pedidos
    /// </summary>
    /// <returns>Pedidos</returns>
    [HttpGet]
    [Route("GetPedidos")]
    public List<Pedido> GetPedidos()
    {
        return ADPedidos.Obtener();
    }
    /// <summary>
    /// OPtenemos la lista de los cadetes
    /// </summary>
    /// <returns>Cadete</returns>
    [HttpGet]
    [Route("GetCadetes")]
    public List<Cadete> GetCadete()
    {
        return ADCadete.Obtener();
    }
    /// <summary>
    /// retorna un Informe
    /// </summary>
    [HttpGet]
    [Route("GetInforme")]
    public void GetInforme()
    {

    }
    /// <summary>
    /// Agrega un pedido a la cadeteria
    /// </summary>
    /// <param name="pedido">Pedido</param>
    [HttpPost]
    [Route("PostPedido")]
    public void AgregarPedido(Pedido pedido)
    {
        
    }
    /// <summary>
    /// Asigno un pedido a un cadete
    /// </summary>
    /// <param name="idPedido"></param>
    /// <param name="idCadete"></param>
    [HttpPut]
    [Route("PutPedido")]
    public void AsignarPedido(int idPedido, int idCadete)
    {

    }
    /// <summary>
    /// Actualizo estado de pedido
    /// </summary>
    /// <param name="idPedido"></param>
    /// <param name="nuevoEstado"></param>
    [HttpPut]
    [Route("PutEstadoPedido")]
    public void CambiarEstadoPedido(int idPedido, int nuevoEstado)
    {

    }
    /// <summary>
    /// Actualizo el pedido para cadete
    /// </summary>
    /// <param name="idPedido"></param>
    /// <param name="idNuevoCadete"></param>
    [HttpPut]
    [Route("CambioCadetePedido")]
    public void CambiarCadetePedido(int idPedido, int idNuevoCadete)
    {
        
    }
}