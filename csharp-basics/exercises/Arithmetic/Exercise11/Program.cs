using System;
using System.Linq;

namespace Exercise11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Moran(int inputNum)
            {
                var numArr = inputNum.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
                if (inputNum % numArr.Sum() == 0)
                {
                    var division = inputNum / numArr.Sum();
                    for (var i = 2; i < division; i++)
                    {
                        if (division % i == 0)
                        {
                            return "H";
                        }
                    }

                    return "M";
                }

                return "Neither";
            }
        }
    }
}