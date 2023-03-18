using StevenOmarAlfaroVillanuevaSemana8.Models;

using AlmacenContext db = new AlmacenContext();

Producto producto = new Producto();

Console.WriteLine("Ingrese el nombre del producto: ");
producto.Nombre = Console.ReadLine();

Console.WriteLine("Descripcion del Producto: ");
producto.Descripcion = Console.ReadLine();

Console.WriteLine("Ingrese el Precio del producto : ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de producto disponible: ");
producto.Stock = Convert.ToInt32(Console.ReadLine());
db.Productos.Add(producto);
db.SaveChanges();

var ListProducto = db.Productos.ToList();

foreach (var produc in ListProducto) 
{
    Console.WriteLine(produc.Nombre);
}