using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carga_csv
{
    internal class Program
    {
        static void Main(String[] args)
        {
           
            AddRecord("125", "nahuel", "rizzo");
        }

        public static void AddRecord(String ID, String name, String surname)
        {
            String ruta = "C:\\Users\\Usuario\\Desktop\\persona.csv";//RUTA DEL ARCHIVO
            String separador = ",";//CREAMOS UN SEPARADOR
            StringBuilder salida = new StringBuilder();//CRAMOS UNA INSTANCIA STRINGBUILDER (QUE LEE EL ARRAY COMPLETO)

            String cadena = ID + "," + name + "," + surname;//HACEMOS UN PROTOTIPO DE REGISTRO
            List<String> List = new List<String>();//CREAMOS UN LISTA DE STRING
            List.Add(cadena);//ASIGNAMOS EL FORMATO CADENA A LA LISTA

            for (int i = 0; i < List.Count; i++)// Count es el número de elementos que están realmente en List<tipo de dato>.
            {
                salida.AppendLine(String.Join(separador, List[i]));// El método AppendLine agrega el terminador de línea predeterminado al final del objeto StringBuilder actual.

                File.AppendAllText(ruta, salida.ToString());//AGREGA LA CADENA AL ARCHIVO.
            }
        }
    }
}
