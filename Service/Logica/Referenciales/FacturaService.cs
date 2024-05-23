using Repository.Repository.Referenciales;

namespace Service.Logica.Referenciales
{
    public class FacturaService
    {
              private readonly FacturaRepository repository;

            public FacturaService(FacturaRepository repository)
            {
                this.repository = repository;
            }
        public int Agregar(int Id, int? Id_cliente, string Fecha_Hora, string Total, string Total_iva_5, string? Total_iva_10, string? Total_Iva, string? Total_Letras, string Sucursal);
       
        }
    }
}
}
