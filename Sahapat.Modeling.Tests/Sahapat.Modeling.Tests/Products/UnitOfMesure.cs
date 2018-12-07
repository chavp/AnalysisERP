using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahapat.Modeling.Tests.Products
{
    public class UnitOfMesure
    {
        /// <summary>
        /// TH(Currency), Palet(Size), Case(Size), Liter(Mass), Set(Size), L(Size), XL(Size)
        /// </summary>
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public Dimension Dimension { get; set; }

    }
}
