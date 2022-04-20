namespace Lab3
{
    public class University
    {
        private string name;
        private string address;
        private int numbFaclt;
        private int studOnFaclt;
        private int rating;
        private int b, a;
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
        
        
    }
}