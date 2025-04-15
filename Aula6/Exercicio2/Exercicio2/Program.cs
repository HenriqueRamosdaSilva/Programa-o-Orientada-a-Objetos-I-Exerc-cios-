using System;

    class Program{
        static void Main(){
            try
            {
            Console.WriteLine("Digite a temperatura");
            string temperaturastring = Console.ReadLine();
            float temperaturaCelsius = Celsius(temperaturastring) ;
            }
            catch ( FormatException)
            {
            Console.WriteLine("Erro: Isso não e uma temperatura, Formato invalido");
            }
            finally
            {
            Console.WriteLine("Bloco finally executado.");
            }

            }
            static float Celsius (string temperaturastring){
            
            float temperatura = float.Parse(temperaturastring);
            return temperatura;

            }
        }

    
