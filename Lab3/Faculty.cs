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
        
        public static void ReadingTxt(string path)
        {
            StreamReader reader = new StreamReader(path);
        }

        public static void WritingTxt(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            
        }

        public void Understandable(int numbCafed, int numbSpec,int numbStudSpec)
        {
            
        }
    }
}