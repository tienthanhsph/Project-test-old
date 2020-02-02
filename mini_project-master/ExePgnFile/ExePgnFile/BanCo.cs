using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExePgnFile
{
    public class BanCo
    {
        public int[,] Table = new int[8,8];
        public BanCo()
        {
            //bàn cờ trống
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Table[i, j] = 0;
                }
            }

            // vị trí của đội trắng
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Table[i,j] = 1;
                }
            }

            //vị trí của đội đen
            for (int i = 0; i < 8; i++)
            {
                for (int j = 6; j < 8; j++)
                {
                    Table[i,j] = 2;
                }
            }
        }
    }
}
