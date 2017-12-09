using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolApp.Helpers
{
    public class ImageHelper
    {
        public static async Task<MediaFile> SeleccionarImagen()
        {
            await CrossMedia.Current.Initialize();
            var file = await CrossMedia.Current.PickPhotoAsync();
            return file;
        }
    }
}
