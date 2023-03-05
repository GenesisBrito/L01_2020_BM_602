using System.ComponentModel.DataAnnotations;
namespace L01_2020_BM_602.Models

{
    public class clientes
    {
        [Key]
        public int clienteid { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }

        public class pedidos
        {
            [Key]
            public int pedidosId { get; set; }
            public int motoristaId { get; set; }
            public int clienteId { get; set; }
            public int platoId { get; set; }
            public int cantidad { get; set; }
            public decimal precio { get; set; }

        }

        public class platos
        {
            [Key]
            public int platoId { get; set; }
            public string nombrePlato { get; set; }
            public decimal precio { get; set; }
        }
        public class motoristas
        {
            [Key]
            public int motoristaId { get; set; }
            public string nombreMotorista { get; set; }
        }

    }
}



