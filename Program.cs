using System;
using operaciones;
using trycatch2;

namespace gavilanch
{
    class Program
    {
        //variables globales
        static void Main(string[] args)
        { // no usar string magicos

            string estatusOperacion = "K15";


            if (estatusOperacion == EstatusOperaciones._exitoso)
            {

            }
            else if (estatusOperacion == EstatusOperaciones._clienteNoEncontrado)
            {

            }
            else if (estatusOperacion == EstatusOperaciones._errorDelsistema)
            {

            }
            ////////////////////////////////////////////////////////////////
            ///EXCEPCIONES
            int a = 1;
            int b = 0;
            try//muestras que esta bien el codio=go
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)//muestras el mensaje de rror
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//muestras el mensaje de rror
            {

                Console.WriteLine(ex.Message);
            }
            finally//siempre se EJECUTA
            {
                Console.WriteLine("esta mal");
            }
            ////////////////////////////////////////////////////////////////

            var persona = new Persona() { nombre = "gelipe", edad = 90 };
            persona = null;
            // te da la opcion de que la variable obtenga Null
            Nullable<int> numero = 45;
            numero = null;

            DateTime? FechaDeNacimiento = null;
            FechaDeNacimiento = new DateTime(2015, 1, 1);

            if (numero.HasValue)//has value te ayuda a identificar si existe valor o no
            {
                Console.WriteLine("El Numero tiene Valor");
            }
            if (FechaDeNacimiento.HasValue)
            {
                Console.WriteLine("La Fecha Tiene Valor");
            }


            ///////////////////////////////////////////////////////////////////

            Console.Read();
        }
        ///<summary>
        ///Metodo Que sirve para sumar
        ///</summary> 
        ///<param name="a"> sumando 1 </param>
        ///<param name="b"> sumando 2 </param>
        ///<returns>retorna la suma de a y b</returns>

        private static int suma(int a, int b)
        {
            return a + b;
        }
        class Persona
        {
            public string nombre;
            public int edad;

        }
    }
}
// clase operaciones 
