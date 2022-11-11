
using NLog;

Console.WriteLine("Hello");

Helper miAyudador = new Helper();
List<Cadete> cadetes = new List<Cadete>();
cadetes = miAyudador.LeerCSVYCrearListaDeCadetes("Cadete.csv");
Cadeteria miCadeteria = new Cadeteria("Envios", 4350358, cadetes);
Console.WriteLine("BIENVENIDO");
Console.WriteLine("Menú alta de pedidos");
Pedido pedido = miCadeteria.altaPedido(1, "Juan", "JBJ 5", 381523654, "Porton negro", "ninguna", false);
Console.WriteLine("Menú asignar cadete");
miCadeteria.asignarPedido(1, pedido);
Console.WriteLine("Menú cambiar estado");

pedido.cambiarEstadoPedido(true);
Console.WriteLine("Menú cambiar cadete");
miCadeteria.reasignarPedido(cadetes[1], cadetes[2], 1);

Console.WriteLine("Menú seleccion salir");
miCadeteria.mostrarInforme();



