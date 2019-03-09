using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
  public  class SysAdminManager
    {
        //Creating Data Access Objects
        private SysAdminService objSysAdminService = new SysAdminService();
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            return objSysAdminService.AdminLogin(objAdmin);
        }
    }
}
