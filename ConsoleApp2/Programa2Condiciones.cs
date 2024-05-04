namespace Programa2_condiciones
{

    public class Program2condiciones
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese la primera nota:");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota:");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota:");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                double promedio = (nota1 + nota2 + nota3) / 3;

                if (promedio >= 7)
                {
                    Console.WriteLine("Promocionado");
                }
                else
                {
                    Console.WriteLine("No promocionado");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
            }
        }
    }
}