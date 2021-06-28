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
           
            ImageGallery GmailShare = new ImageGallery(new Gmail());
            GmailShare.Share();
            ImageGallery WhatsUpShare = new ImageGallery(new WhatsUp());
            WhatsUpShare.Share();
            ImageGallery BluetoothShare = new ImageGallery(new Bluetooth());
            BluetoothShare.Share();



        }
    }
}
