using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int num)
        {
            if (num < 2){

                return false;
            }

            throw new NotImplementedException("Please create a test first.");
        }

        public static int Edades(int y,int m,int d)
        {
            DateTime nacimiento = new DateTime(y,m,d); //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            return edad;
        }

        public static double CSalario(double num){

            double salario = 0;

            if (num == 0) return 0;

            if (num <= 416.22){
                Console.WriteLine("Monto exento");
                return num;
            }
            if(num <= 416.221 || num > 624.329){

                Console.WriteLine("Aplicando el 15% de excedentes");
                salario = 0.15 * num;
                
            }

            if(num >= 624.33 || num <= 867.123){
                
                Console.WriteLine("Aplicando el 20% de excedente");
                salario = 0.2 * num;
            }

            if(num >= 867.124 ){
                Console.WriteLine("Aplicando el 25% de excedente");
                salario = 0.25 * num;
            }

            return salario;
        }
    }
}
