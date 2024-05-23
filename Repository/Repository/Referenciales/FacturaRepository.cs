using Repository.Contexts;
using Repository.Entidades;

namespace Repository.Repository.Referenciales
{
    public class FacturaRepository
    {
        private readonly ContextoAplicacionDB _contexto;

        public FacturaRepository(ContextoAplicacionDB contexto)
        {
            _contexto = contexto;
        }

        public bool Agregar(int Id, int? Id_cliente, string Fecha_Hora, string Total, string Total_iva_5, string?Total_iva_10, string? Total_Iva, string? Total_Letras, string Sucursal)
        {
            Factura cliente = new Factura()
            {
                FechaHora = Fecha_Hora, 
                Total=Total,
                Total_Iva_5 =Total_iva_5
                Total_Iva_10= Total_iva_10,
                TotalLetras = Total_Letras, Sucursal = Sucursal,    

            
            }


            _contexto.Clientes.Add(cliente);
            int resultado = _contexto.SaveChanges();

            return resultado;
        }
    }
}
}
