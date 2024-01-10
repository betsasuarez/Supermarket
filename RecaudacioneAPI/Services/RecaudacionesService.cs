using RecaudacioneAPI.Models;

namespace RecaudacioneAPI.Services
{
    public class RecaudacionesService : IRecaudacionesService
    {
        private readonly List<Cliente> _clientes = new List<Cliente>
    {
        new Cliente { Id = 1, Nombre = "Cliente1", ValorAPagar = 50.0m },
        new Cliente { Id = 2, Nombre = "Cliente2", ValorAPagar = 30.0m }
        // Agregar más clientes según sea necesario
    };

        private readonly List<ProductoCosmetico> _productosCosmeticos = new List<ProductoCosmetico>
    {
        new ProductoCosmetico { Id = 1, Nombre = "Crema Facial", Precio = 20.0m },
        new ProductoCosmetico { Id = 2, Nombre = "Lápiz Labial", Precio = 15.0m }
        // Agregar más productos según sea necesario
    };

        public decimal ObtenerValorAPagarCliente(int clienteId)
        {
            var cliente = _clientes.FirstOrDefault(c => c.Id == clienteId);

            if (cliente == null)
            {
                throw new InvalidOperationException("Cliente no encontrado");
            }

            return cliente.ValorAPagar;
        }

        public decimal ObtenerPrecioProducto(int productoId)
        {
            var producto = _productosCosmeticos.FirstOrDefault(p => p.Id == productoId);

            if (producto == null)
            {
                throw new InvalidOperationException("Producto no encontrado");
            }

            return producto.Precio;
        }
    }

}

