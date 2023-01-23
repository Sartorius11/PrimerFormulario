using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {

        //NECESITAMOS UN METODO PARA LEER FICHEROS
        //ESTE METODO DEVUELVE EL STRING DEL FILE
        //EN LAS CLASES, LOS METODOS ASINCRONOS
        //UTILIZAN LA CLASE Task PARA SU DECLARACION
        //SI ES UN void, SIMPLEMENTE LA PALABRA Task
        //SI ES UN return, SE UTILIZA Task<Tipo>
        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            //PARA LEER VAMOS A UTILIZAR using
            //PARA ASEGURARNOS QUE DENTRO DEL CODIGO
            //EL OBJETO SIEMPRE ESTARA ACCESIBLE
            string contenido = "";
            using (TextReader reader = file.OpenText())
            {
                //DENTRO DE ESTE CODIGO DEBEMOS UTILIZAR READER
                //Y DESPUES QUEDARA DESTRUIDO
                //LA LECTURA DEBEMOS HACERLA DE FORMA ASINCRONA
                contenido = await reader.ReadToEndAsync();
                reader.Close();
            }
            return contenido;
        }

        //METODO PARA ESCRIBIR EN UN FILE
        //ESTE METODO ES DE ACCION (void)
        //NO DEVUELVE NADA
        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
