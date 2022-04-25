using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab3
{
    public class Faculty
    {
        private string nameFaculty;
        private int numbCafed;
        private int numbSpec;
        private int numbStudSpec;
        public string path="/Users/timofejvoznesenskij/RiderProjects/Lab3/Lab3/univer.txt";
        
        public Faculty()
        {
            nameFaculty = "";
            numbCafed = 0;
            numbSpec = 0;
            numbStudSpec = 0;
        }

        public Faculty(string nameFaculty, int numbCafed, int numbSpec, int numbStudSpec)
        {
            this.nameFaculty = nameFaculty;
            this.numbCafed = numbCafed;
            this.numbSpec = numbSpec;
            this.numbStudSpec = numbStudSpec;
        }

        public string NameFaclty
        {
            set { nameFaculty = value; }
            get { return nameFaculty; }
        }

        public int NumbCafed
        {
            set { numbCafed = value; }
            get { return numbCafed; }
        }

        public int NumbSpec
        {
            set { numbSpec = value; }
            get { return numbSpec; }
        }

        public int NumbStudSpec
        {
            set { numbStudSpec = value; }
            get { return numbStudSpec; }
        }

        public class StartupIncubator
        {
            public int numbStart=5;
            public int studStart=10;
            public int investment;

            public double BestStartup(int numbStart, int numbJudge)
            {
                int i, j, n;
                
                double[] subArr = new double[numbStart];
                int[,] arr = new int[numbStart, numbJudge];
                Random rand = new Random();
                for (i = 0; i < numbStart; i++)
                {
                    for (j = 0; j < numbJudge; j++)
                    {
                        arr[i, j] = rand.Next(0, 10);
                    }
                }

                for (i = 0; i < numbStart; i++)
                {
                    for (j = 0; j < numbJudge; j++)
                    {
                        subArr[i] += arr[i, j];
                    }
                }
             
                for(i=0;i<numbStart;i++)
                {
                    subArr[i]=subArr[i]/numbStart;
                }
                
             
                for ( i = 1; i < numbStart; i++)
                {
                    double key = subArr[i];
                    n = i - 1;
                
                    while (n>=0 && subArr[n]>key)
                    {
                        subArr[n+1] = subArr[n];
                        subArr[n] = key;
                        n--;
                    }
                }

                return subArr[0];

            }
        }
    }
}
