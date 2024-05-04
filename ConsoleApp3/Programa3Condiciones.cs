namespace Programa3_condiciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Poner la primera nota:");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Poner la segunda nota:");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Pomer la tercera nota:");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                double promedio = (nota1 + nota2 + nota3) / 3;

                string mensaje = "";
                if (promedio >= 7)
                {
                    mensaje = "Promocionado";
                }
                else if (promedio >= 4)
                {
                    mensaje = "Regular";
                }
                else
                {
                    mensaje = "Reprobado";
                }

                Console.WriteLine($"El alumno está {mensaje}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
            }
        }
    }
}

