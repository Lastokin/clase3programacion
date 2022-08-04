// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("**calculo de precios de los productos xx **");
Console.WriteLine("Hoy al ser un dia festivo tenemos una promocion para ti");
Console.WriteLine("todos los productos que se compren se le aplican un descuento del 11%");
Console.WriteLine("ingrese el precio del producto que desea comprar");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese la cantidad de productos que desea comprar");
int cantidad = int.Parse(Console.ReadLine());
double desc = 0.11;

double importe = precio * cantidad;
Console.WriteLine("El importe total de la transaccion es de " + importe);

double importedesc = (precio * cantidad) * desc;
Console.WriteLine("Descuento del importe es: " + importedesc);

double precioFinal = (precio * cantidad) - importedesc;
Console.WriteLine("El precio final es de: " + precioFinal);
