using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public   int  SumTriangle()


        {
            string workingDirectory = Environment.CurrentDirectory;
            string path= Path.Combine(Directory.GetParent(workingDirectory).Parent.FullName, @"Triangle\", @"Triangle.txt");
            //whole to a single string
            string text = File.ReadAllText(path);

            /* split and input on 2d array*/
            
            var Triangle = text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
       
                .Select(line => line.Trim()
                    .Split(' ')
                    .Select(s => int.Parse(s.Trim()))
                    .ToArray())
                .ToArray();

            return SumTree(Triangle);

        }

        //DP  bottom-up  
        // for each element, check both 
        // elements just below the number 
        // and below right to the number 
        // add the maximum of them to it 



        private int SumTree(int[][] Triangle)
        {
           
            for (int i = Triangle.Length - 2; i >=0; i--)
            {
                for (int j=0;j<= Triangle[i].Length-1;j++)
                {

                    if (Triangle[i + 1][j] > Triangle[i + 1][ j + 1])

                        Triangle[i][ j] += Triangle[i + 1][ j];

                    else
                        Triangle[i][ j] += Triangle[i + 1][ j + 1];



                }
            }
            return Triangle[0][0];

        }

     

       

    }
}


