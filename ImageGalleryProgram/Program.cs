using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _gmail = new Gmail();
            WhatsUp _whatsup = new WhatsUp();
            Bluetooth _bluetooth = new Bluetooth();

            ImageGallery imageGallery = new ImageGallery();
            imageGallery.Share(_gmail);
            
            imageGallery.Share(_whatsup);

            imageGallery.Share(_bluetooth);



        }
    }
}
