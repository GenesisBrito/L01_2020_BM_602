using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2020_BM_602.Models;
using Microsoft.EntityFrameworkCore;
using static L01_2020_BM_602.Models.clientes;

namespace L01_2020_BM_602.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class restauranteController : ControllerBase
    {
        private readonly restauranteContext _restauranteContexto;

        public restauranteController(restauranteContext restauranteContexto)
        {
            _restauranteContexto = restauranteContexto;
        }
    }
    /// <summary>
    /// EndPoint que retorna el listado
    /// </summary>
    /// <returns></returns>

    [ApiController]
    [Route("[controller]")]
    public class platosController : ControllerBase
    {
        private readonly List<platos> _platos;

        public platosController()
        {
            // Inicializar los datos de prueba
            _platos = new List<platos>
            {
                new platos { platoId = 1, nombrePlato  = "Plato1", precio = 10 },
                new platos { platoId = 2, nombrePlato  = "Plato2", precio = 20 },
                new platos { platoId = 3, nombrePlato  = "Plato3", precio = 30 },
                new platos { platoId = 4, nombrePlato  = "Plato4", precio = 40 },
                new platos { platoId = 5, nombrePlato  = "Plato5", precio = 50 }
            };
        }

        // GET /plates
        [HttpGet]
        public IEnumerable<platos> Get()
        {
            return _platos;
        }
        [HttpGet]
        // GET /plates/5
        [HttpGet("{id}")]
        public platos Get(int id)
        {
            return _platos.FirstOrDefault(p => p. platoId == id);
        }

        // POST /plates
        [HttpPost]
        public void Post([FromBody] platos plato)
        {
            _platos.Add(plato);

            // PUT /plates/5

            [HttpPut("{id}")]

             void put(int id, [FromBody] platos plato)
            {
                var existingPlato = _platos.FirstOrDefault(p => p.platoId == id);

                if (existingPlato != null)
                {
                    existingPlato.nombrePlato = plato.nombrePlato;
                    existingPlato.precio = plato.precio;
                }

                put(id, plato);
            }

            // DELETE /platos/5
            [HttpDelete("{id}")]
             void Delete(int id)
            {
                var plateToDelete = _platos.FirstOrDefault(p => p.platoId == id);
                if (plateToDelete != null)
                {
                    _platos.Remove(plateToDelete);
                } 

                Delete(id);
            }

            // GET /plates/search?query=Plato
            [HttpGet("search")]
             IEnumerable<platos> Search(string query)
            {
                return _platos.Where(p => p.nombrePlato.Contains(query));

                Search(query);
            }

        }
    }

}
