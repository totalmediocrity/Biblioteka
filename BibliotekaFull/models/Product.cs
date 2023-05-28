using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace BibliotekaFull.models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Cost { get; set; }

    public string Descrip { get; set; } = null!;

    public byte[] Image { get; set; } = null!;

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public ImageSource bdImage
    {
        get
        {

            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream mem = new MemoryStream(Image);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = mem;
            bitmapImage.EndInit();

            return bitmapImage as ImageSource;
        }
    }
}
