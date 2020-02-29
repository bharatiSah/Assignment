using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment.ModelClass;

namespace Assignment
{
    class BusinessLayer
    {
        DataAccessLayer dataaccesslayer = new DataAccessLayer();
        public List<WholeDetails> Bl_GetAllRequireDetails()
        {
            return (dataaccesslayer.GetAllRequireDetails());
        }

        public List<ChangeData> Bl_GetChangeDetails()
        {
            return dataaccesslayer.GetAllChangeDetails();
        }
    }
}
