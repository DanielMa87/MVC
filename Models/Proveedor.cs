
using System.ComponentModel.DataAnnotations;

namespace MVC_Productos.Models
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List <Producto>ListaProdutos  { get;set;}
    }
}