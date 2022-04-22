using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public class University
    {
        private string name;
        private string address;
        private int numbFaclt;
        private int studOnFaclt;
        private int rating;
        
        public int scopus;
        public int top200;
        public int balzno;
        
        public int firstPosition;
        public int secondPosition;
        public int thirdPosition;

        public int financing;

        public University()
        {
            name = "";
            address = "";
            numbFaclt = 0;
            studOnFaclt = 0;
            rating = 0;
        }

        public University(string name, string address, int numbFaclt, int studOnFaclt, int rating)
        {
            this.name = name;
            this.address = address;
            this.numbFaclt = numbFaclt;
            this.studOnFaclt = studOnFaclt;
            this.rating = rating;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Address
        {
            set { address = value; }
            get { return address; }
        }

        public int NumbFaclt
        {
            set { numbFaclt = value; }
            get { return numbFaclt; }
        }

       public int StudOnFaclt
        {
            set { studOnFaclt = value; }
            get { return studOnFaclt; }
        }

        public int Rating
        {
            set { rating = value; }
            get { return rating; }
        }

        public void Scopus()
        {
            Random rnd = new Random();
            firstPosition = rnd.Next(0, 40);
            secondPosition = rnd.Next(0, 40);
            thirdPosition = rnd.Next(0, 40);
            scopus = firstPosition + secondPosition + thirdPosition;
        }

        public void Top200()
        {
            Random rnd = new Random();
            firstPosition = rnd.Next(0, 40);
            secondPosition = rnd.Next(0, 40);
            thirdPosition = rnd.Next(0, 40);
            top200 = firstPosition + secondPosition + thirdPosition;
        }

        public void BalZno()
        {
            Random rnd = new Random();
            firstPosition = rnd.Next(0, 40);
            secondPosition = rnd.Next(0, 40);
            thirdPosition = rnd.Next(0, 40);
            balzno = firstPosition + secondPosition + thirdPosition;
        }

        public int CountRating()
        {
            int ratingg = scopus + balzno + top200;
            return ratingg;
        }

        public int Financing( string city)
        {
            if (rating > 150 && (city == "Kyiv" || city == "Lviv" || city == "Kharkiv"))
                financing = 5000 * studOnFaclt;
            
            else if (rating < 150 && rating > 100 && (city == "Kyiv" || city == "Lviv" || city == "Kharkiv"))
                financing = 3800 * studOnFaclt;
            
            else if (rating < 150)
                 financing = 3000 * studOnFaclt;
            
            return financing;
        }
        
    }
}