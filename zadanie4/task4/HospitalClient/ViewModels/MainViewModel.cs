using HospitalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClient.ViewModels
{
    class MainViewModel
    {
        public ElementsListViewModel ElementsList { get; private set; }
        public Query query = new Query();

        public MainViewModel()
        {
            ElementsList = new ElementsListViewModel();
        }

        public void SetElementsListWithEmployees()
        {
            List<string> names = query.getEmployeesNamesList();
            List<string> surnames = query.getEmployeesSurnamesList();
            List<string> professions = query.getEmployeesProfessionsList();

            ElementsList.Content = "";
            
            for(int i = 0; i < names.Count; ++i )
            {
                ElementsList.Content += names[i] + " " + surnames[i] + " zawód: "
                                     + professions[i] + Environment.NewLine;
            }
        }

        public void SetElementsListWithPatients()
        {
            List<string> names = query.getPatientNamesList();
            List<string> surnames = query.getPatientSurnamesList();
            List<string> diseases = query.getPatientDiseasesList();

            ElementsList.Content = "";

            for (int i = 0; i < names.Count; ++i)
            {
                ElementsList.Content += names[i] + " " + surnames[i] + " choroba: "
                                     + diseases[i] + Environment.NewLine;
            }
        }
        public void SetElementsListWithDepartments()
        {
            List<string> departments = query.ListDepartments();

            ElementsList.Content = "";

            for (int i = 0; i < departments.Count; ++i)
            {
                ElementsList.Content += departments[i] + Environment.NewLine;
            }
        }

        public void SetElementsListWithRooms()
        {
            List<string> rooms = query.ListRooms();

            ElementsList.Content = "";

            for (int i = 0; i < rooms.Count; ++i)
            {
                ElementsList.Content += rooms[i] + Environment.NewLine;
            }
        }
    }
}

