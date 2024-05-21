using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonKenPo.Model
{
    public class Escolha
    {
        public int Side { get; set; }

        public Escolha(int side)
        {
            Side = side;
        }

       public int Roll()
        {
            return new Random().Next(Side);
        }
    }
    
}
