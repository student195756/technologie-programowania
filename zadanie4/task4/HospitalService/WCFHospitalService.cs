using HospitalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HospitalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFHospitalService" in both code and config file together.
    public class WCFHospitalService : IWCFHospitalService
    {
        public List<string> ListDepartments()
        {
            Console.WriteLine("ListDepartments() zostala wywolana przez klienta");

            List<string> departmentsList = new List<string>();

            try
            {
                using (szpitalEntities database = new szpitalEntities())
                {
                    var departments = from o in database.oddzialy
                                      select o.nazwa;

                    departmentsList = departments.ToList();
                }
            }
            catch
            {

            }

            return departmentsList;
        }
    }
}
