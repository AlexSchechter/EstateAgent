namespace Estates.Business
{
    public class Estate
    {
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int SqF { get; set; }
        public string Postcode { get; set; }
        public int EstateID { get; set; }

        public Estate(int bedrooms, int bathrooms, int sqF, string postcode, int estateId)
        {
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            SqF = sqF;
            Postcode = postcode;
            EstateID = estateId;
        }
    }   
}
