using System.ComponentModel.DataAnnotations;

namespace webApi.Models{
    public class Clientes{
        [Key]
        public int id_cliente{get;set;}
        public string nit {get;set;}
        public string nombres {get;set;}
        public string apellidos {get;set;}
        public string direccion {get;set;}
        public string telefono {get;set;}
    }
}