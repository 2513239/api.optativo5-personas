using Repository.Contexts;
using Repository.Entidades;
using Repository.Repository.Referenciales;

namespace Service.Logica.Referenciales
{
    public class ClienteService
    {
        private readonly ClienteRepository repository;
        private string v;
        private ContextoAplicacionDB contexto;

        public  ClienteService(ClienteRepository repository)
        {
            this.repository = repository;
        }

        public ClienteService(string v)
        {
            this.v = v;
        }

        public ClienteService(ContextoAplicacionDB contexto)
        {
            this.contexto = contexto;
        }

        public int Agregar(int Id, int? IdBanco, string Nombre, string Apellido, string Documento, string? Direccion, string? Mail, string? Celular, string Estado) => repository.Agregar(Id, IdBanco, Nombre, Apellido, Documento, Direccion, Mail, Celular, Estado);

        public object consultarCliente(int id)
        {
            throw new NotImplementedException();
        }

        public object insertarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public object list()
        {
            throw new NotImplementedException();
        }

        public object modificarCliente(Cliente cliente, int id)
        {
            throw new NotImplementedException();
        }

        public object remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
