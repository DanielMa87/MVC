
using System.ComponentModel.DataAnnotations;

namespace MVC_Productos.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion{ get; set; }
        
        //para cada catergora hay n productos
        public List <Producto>ListaProdutos  { get;set;}

    }
}