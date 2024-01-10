namespace RecaudacioneAPI.Services
{
    public interface IRecaudacionesService
    {
        decimal ObtenerValorAPagarCliente(int clienteId);
        decimal ObtenerPrecioProducto(int productoId);
    }
}
