namespace Lab3
{
    public partial class University
    {
        public int Financing(string city, string address)
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