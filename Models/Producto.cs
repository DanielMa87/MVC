namespace MVC_Productos.Models{
    using System.ComponentModel.DataAnnotations;
    public class Producto{
        [Key]
        public int Id { get; set;}
        public string Nombre { get; set;}
        public string Descripcion{ get; set;}
        public decimal Precio{ get; set;}
        //referecia a su categroria 
        public int CategoriaId { get;set;}//fk hacia producto
        public Categoria? Categoria{ get; set; }//una categoria 

        public int ProveedorId { get; set;}//fk a hacia proveedor 
        public Proveedor? Proveedor{ get; set;}//un proveedor "?" quiere decir que puede ser nula
    }
}
