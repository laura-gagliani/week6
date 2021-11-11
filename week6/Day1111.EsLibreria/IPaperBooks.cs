using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
     public interface IPaperBooks :ICommon<PaperBook>
    {
        public void ModifyStockQuantity(PaperBook item, int quantity);
    }
}
