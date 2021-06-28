using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image
{
    
        public class ImageGallery
        {
        Isender sender;
        public ImageGallery(Isender _sender)
        {
            this.sender = _sender;
        }
            public void Share()
            {
                sender.Send();

            }
        }

       
        
        
        

        
}
