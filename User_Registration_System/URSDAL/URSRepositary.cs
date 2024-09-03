using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URSDAL
{
    public class URSRepositary
    {
        public List<UserDetail> GetUserList()
        {
            URSDBEntities db = new URSDBEntities();
            List<UserDetail> result = new List<UserDetail>();
            result = (from i in db.UserDetails select i).ToList();
            return result;
        }


        public bool AddUser(UserDetail obj)
        {
            try
            {
                URSDBEntities db = new URSDBEntities();
                db.UserDetails.Add(obj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }

    }
}
