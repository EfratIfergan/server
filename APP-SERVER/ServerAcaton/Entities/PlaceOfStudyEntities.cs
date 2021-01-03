using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Entities
{
   public class PlaceOfStudyEntities
    {
        public int? CategoryCode { get; set; }
        public string Miles { get; set; }
        public int ParticipantCode { get; set; }

        public static PlaceOfStudyEntities ToPlaceOfStudyEntities(Participants c)
        {
            PlaceOfStudyEntities cnew = new PlaceOfStudyEntities() { CategoryCode = c.CategoryCode, Miles = c.Miles, ParticipantCode = c.ParticipantCode };

            return cnew;
        }

        public static Participants ToPlaceOfStudyTbl(PlaceOfStudyEntities c)
        {
            Participants cnew = new Participants() { CategoryCode = c.CategoryCode, Miles = c.Miles, ParticipantCode = c.ParticipantCode };


            return cnew;
        }

        public static List<PlaceOfStudyEntities> ToListPlaceOfStudyEntities(List<Participants> lc)
        {
            List<PlaceOfStudyEntities> lcnew = new List<PlaceOfStudyEntities>();
            lc.ForEach(c => lcnew.Add(ToPlaceOfStudyEntities(c)));


            return lcnew;
        }

        public static List<Participants> ToPlaceOfStudyTBL(List<PlaceOfStudyEntities> lc)
        {
            List<Participants> lcnew = new List<Participants>();
            lc.ForEach(c => lcnew.Add(ToPlaceOfStudyTbl(c)));
            return lcnew;
        }



    }
}
    

