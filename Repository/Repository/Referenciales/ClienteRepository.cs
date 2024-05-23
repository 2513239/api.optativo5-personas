using Repository.Entidades;

using Repository.Contexts;

namespace Repository.Repository.Referenciales
{
    public class ClienteRepository
    {
        private readonly ContextoAplicacionDB _contexto;

        public ClienteRepository(ContextoAplicacionDB contexto)
        {
            _contexto = contexto;
        }

        public bool Agregar(int Id,int? IdBanco, string Nombre,string Apellido, string Documento, string? Direccion, string? Mail, string? Celular,string Estado)
        {
            Cliente cliente = new Cliente()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Documento = Documento,
                Direccion = Direccion,
                Mail = Mail,
                Celular = Celular,
                Estado = Estado
            };

            _contexto.Clientes.Add(cliente);
            int resultado =  _contexto.SaveChanges();
         
            return resultado;
        }
    }
}   
