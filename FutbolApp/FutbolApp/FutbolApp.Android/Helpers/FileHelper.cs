using System;
using System.IO;

namespace FutbolApp.Droid.Helpers
{
    public class FileHelper
    {
        public static string ObtenerRutaLocal(string archivo)
        {
            //Vamos a persistir la BD en la carpeta de documentos
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(ruta, archivo);
        }
    }
}