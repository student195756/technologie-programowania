using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HospitalInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFHospitalService" in both code and config file together.
    [ServiceContract]
    public interface IWCFHospitalService
    {
        [OperationContract]
        List<string> listDepartments();

        [OperationContract]
        string showDepartment(int id);

        [OperationContract]
        void removeDepartment(int id);

        [OperationContract]
        List<string> listRooms();

        [OperationContract]
        List<string> listPatients();

        [OperationContract]
        string showPatient(int id);

        [OperationContract]
        List<string> listEmployees();

        [OperationContract]
        string showEmployee(int id);
    }
}
