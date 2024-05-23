using Microsoft.AspNetCore.Mvc;
using Repository.Contexts;
using Repository.Entidades;
using Repository.Models;
using Service.Logica.Referenciales;

namespace api.persona.Controllers
{
    [Route("api/v1/[controller]")]
    public class PersonaController : Controller
    {
        private PersonaService personaService;
        private PersonaService2 personaService2;
        private ClienteService clienteService;

        public PersonaController(IConfiguration configuracion, ContextoAplicacionDB contexto)
        {
            personaService = new PersonaService(configuracion.GetConnectionString("postgresConnection"));
            personaService2 = new PersonaService2(contexto);
            clienteService = new ClienteService(contexto);
        }
        [HttpPost]
        public ActionResult add([FromBody] PersonaModel persona)
        {
            personaService.add(persona);
            return Ok(new { message = "Registro insertado Correctamente" });
        }

        [HttpPost("entity-framework")]
        public ActionResult AgregarConEntity([FromBody] Persona persona)
        {
            int resultado = personaService2.Agregar(persona.Nombre, persona.Apellido, persona.AnhoNacimiento);
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public ActionResult ObtenerPorId([FromRoute] int id)
        {
            var resultado = personaService2.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPut("{id}")]
        public ActionResult Actualizar([FromRoute] int id, [FromBody] string nombre)
        {
            var resultado = personaService2.Actualizar(id, nombre);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public ActionResult Eliminar([FromRoute] int id)
        {
            var resultado = personaService2.Eliminar(id);
            return Ok(resultado);
        }
        [Route("api/v1/[controller]")]
        public class ClienteController : Controller
        {
            private readonly ClienteService ClienteServices;
            private readonly IConfiguration configuration;

            public ClienteController(IConfiguration _configuration)
            {
                this.configuration = _configuration;
                this.ClienteServices = new ClienteService(configuration.GetConnectionString("postgresConnection"));
            }

            [HttpGet("listarCliente")]
            public ActionResult<List<Cliente>> ListarCliente()
            {
                var resultado = ClienteServices.list();
                return Ok(resultado);
            }
            [HttpGet("consultarCliente/{id}")]
            public ActionResult<Cliente> ConsultarCliente(int id)
            {
                var resultado = this.ClienteServices.consultarCliente(id);
                return Ok(resultado);
            }
            [HttpPost("insertarCliente")]
            public ActionResult<string> insertarCliente(Cliente modelo)
            {
                var resultado = this.ClienteServices.insertarCliente(new Cliente
                {
                    Nombre = modelo.Nombre,
                    Apellido = modelo.Apellido,
                    Documento = modelo.Documento,
                    Direccion = modelo.Direccion,
                    Mail = modelo.Mail,
                    Celular = modelo.Celular,
                    Estado = modelo.Estado,
                    IdBanco = modelo.IdBanco
                });
                return Ok(resultado);
            }
            [HttpPut("modificarCliente/{id}")]
            public ActionResult<string> modificarCliente(Cliente modelo, int id)
            {
                var resultado = this.ClienteServices.modificarCliente(new Cliente
                {
                    Nombre = modelo.Nombre,
                    Apellido = modelo.Apellido,
                    Documento = modelo.Documento,
                    Direccion = modelo.Direccion,
                    Mail = modelo.Mail,
                    Celular = modelo.Celular,
                    Estado = modelo.Estado,
                    IdBanco = modelo.IdBanco
                }, id);
                return Ok(resultado);
            }
            [HttpDelete("eliminarCliente/{id}")]
            public ActionResult<string> eliminarCliente(int id)
            {
                var resultado = this.ClienteServices.remove(id);
                return Ok(resultado);
            }

        }
    }
}

