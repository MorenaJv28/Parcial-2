int dat1 = 16;
String dat2 = "25g";
try
{
    int resultado = dat1 + Convert.ToInt32(dat2);
    Console.WriteLine(resultado);
}
catch (Exception)
{
    Console.WriteLine("No se pudo realizar la operación solicitada");
}