// See https://aka.ms/new-console-template for more information

using SistemaGestionCoderHouse;

//Listar productos
Console.WriteLine("Lista de Productos");
Console.WriteLine("-------------------");

List<Producto> productos = ProductoData.ListarProductos();

foreach(var item in productos)
{
    Console.WriteLine($"Id: {item.Id} - Descripciones: {item.Descripciones} - Costo: {item.Costo} - Precio Venta: {item.PrecioVenta} - Stock: {item.Stock} - Id Usuario: {item.IdUsuario}");
}

//Obtener un producto por su Id
Console.WriteLine("Obtener un producto por su Id");
Console.WriteLine("-------------------------------");
int productoId = 2;
Producto productoObtenido = ProductoData.ObtenerProductoPorId(productoId);
if (productoObtenido != null)
{
    Console.WriteLine($"Producto obtenido - ID: {productoObtenido.Id}, Descripción: {productoObtenido.Descripciones}");
}
else
{
    Console.WriteLine($"No se encontró un producto con ID {productoId}");
}

//Crear un nuevo producto de prueba
Producto nuevoProducto = new Producto
{
    Descripciones = "Producto de Prueba",
    Costo = 15.0m,
    PrecioVenta = 25.0m,
    Stock = 100,
    IdUsuario = 1
};
//ProductoData.CrearProducto(nuevoProducto);

//Modificar el producto recién creado
//nuevoProducto.Descripciones = "Producto Modificado";
//ProductoData.ModificarProducto(nuevoProducto);

//Eliminar el producto segun id
//int productoEliminadoId = 7;
//ProductoData.EliminarProducto(productoEliminadoId);

//Listar usuarios
Console.WriteLine("Lista de Usuarios");
Console.WriteLine("------------------");

List<Usuario> usuarios = UsuarioData.ListarUsuarios();

foreach(var item in usuarios)
{
    Console.WriteLine($"Id: {item.Id} - Nombre: {item.Nombre} - Apellido: {item.Apellido} - Nombre Usuario: {item.NombreUsuario} - Contraseña: {item.Contraseña} - Mail: {item.Mail}");
}

//Listar Ventas
Console.WriteLine("Lista de Ventas");
Console.WriteLine("----------------");

List<Venta> ventas = VentaData.ListarVentas();

foreach(var item in ventas)
{
    Console.WriteLine($"Id: {item.Id} - Comentarios: {item.Comentarios} - Id Usuario: {item.IdUsuario}");
}

//Listar ProductosVendidos
Console.WriteLine("Lista de Productos Vendidos");
Console.WriteLine("---------------------------");

List<ProductoVendido> productosVendidos = ProductoVendidoData.ListarProductosVendidos();

foreach(var item in productosVendidos)
{
    Console.WriteLine($"Id: {item.Id}  - Stock: {item.Stock} - Id Producto: {item.IdProducto} - Id Venta: {item.IdVenta}");
}

