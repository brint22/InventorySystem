using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public byte[] ImageData { get; set; }

        internal static Image FromStream(MemoryStream ms)
        {
            throw new NotImplementedException();
        }
    }

}
