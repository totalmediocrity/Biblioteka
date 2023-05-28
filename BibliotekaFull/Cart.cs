using BibliotekaFull.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaFull
{
    public static class Cart
    {
        public static List<OrderProduct> Products = new List<OrderProduct>();

        public static int CurrentUserID;
    }
}
