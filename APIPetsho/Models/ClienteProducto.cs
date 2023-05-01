namespace APIPetshop.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? cedula { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public int edad { get; set; }
        public string? correo { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public double valor { get; set; }
        public int cantidad { get; set; }
    }
}
