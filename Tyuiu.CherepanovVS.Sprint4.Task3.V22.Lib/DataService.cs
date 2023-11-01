using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.CherepanovVS.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int x = 0;
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < colums; j++)
                {
                    if ((j >=0 && j <=3) && i==1 )
                    {
                        if (array[i, j] > x)
                        {
                            x = array[i, j];
                        }
                    }
                }
            return x;
        }
    }
}
