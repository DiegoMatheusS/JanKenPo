using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonKenPo.Model
{
    public class Jogo
    {
        public int Side { get; set; }

        public Jogo(int side)
        {
            Side = side;
        }

        public int Roll()
        {
            return new Random().Next(Side);
        }
    }
}
