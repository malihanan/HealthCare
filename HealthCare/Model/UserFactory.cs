using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCare.Model
{
    class UserFactory
    {
        public User CreateUser(UserType? type)
        {
            User user = null;
            if(type == null)
            {
                user = new User();
            }
            else if (type == UserType.PATIENT)
            {
                user = new Patient();
            } 
            else if (type == UserType.DOCTOR)
            {
                user = new Doctor();
            }
            else if (type == UserType.PHARMACIST)
            {
                user = new Pharmacist();
            }
            else if(type == UserType.LAB_TECHNICIAN)
            {
                user = new LabTechnician();
            }
            return user;
        }
    }
}
