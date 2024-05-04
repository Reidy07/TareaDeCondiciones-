namespace Programa1_condiciones
{

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Poner el primer número:");
                double numero1 = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Poner el segundo número:");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                if (numero1 > numero2)
                {
                    double suma = numero1 + numero2;
                    double diferencia = numero1 - numero2;

                    Console.WriteLine($"La suma de los dos números es: {suma}");
                    Console.WriteLine($"La diferencia de los dos números es: {diferencia}");
                }
                else
                {
                    double producto = numero1 * numero2;
                    if (numero2 != 0)
                    {
                        double division = numero1 / numero2;
                        Console.WriteLine($"El producto de los dos números es: {producto}");
                        Console.WriteLine($"La división del primero respecto al segundo es: {division}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede realizar la división porque el segundo número es 0.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error al poner los numeros: {ex.Message}");
           

            }
        }
      
    }
  
}