using Estates.Business.dsEstatesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Business
{
    static public class EstateRepository
    {
        private static EstateInfoTableAdapter estateInfoTableAdapter
        {
            get { return new EstateInfoTableAdapter(); }
        }

        public static List<Estate> ListEstates()
        {
            List<Estate> allEstates = new List<Estate>();
            var dataOfEstates = estateInfoTableAdapter.GetData();

            foreach (dsEstates.EstateInfoRow estateRow in dataOfEstates)
            {
                Estate currentEstate = new Estate(estateRow.Bedrooms,
                                                  estateRow.Bathrooms,
                                                  estateRow.SqF,
                                                  estateRow.Postcode,
                                                  estateRow.Id);

                allEstates.Add(currentEstate);
            }
            return allEstates;
        }

        public static void SaveEstate(int bedrooms, int bathrooms, string postcode, int sqF)
        {
            estateInfoTableAdapter.InsertEstate(bedrooms, bathrooms, postcode, sqF);
        }

        public static void DeleteEstate(int estateID)
        {
            estateInfoTableAdapter.DeleteEstate(estateID);
        }


    }
}
