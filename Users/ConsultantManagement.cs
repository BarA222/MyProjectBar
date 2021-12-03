using Contracts;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    public class ConsultantManagement : IConsultants
    {
        private ConsultantRepository repo = new ConsultantRepository();
        public void CheckMyMeetings(DateTime date)
        {
            throw new NotImplementedException();
        }



    }
}
