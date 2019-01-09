using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService
{
    public class Query
    {
        LinqToSqlDataContext db = new LinqToSqlDataContext();

        public string getDepartment(int id)
        {
            string department = (from d in db.oddzialies
                                 where d.id_oddzialu == id
                                 select d.nazwa).First().ToString();

            return department;
        }

        public List<string> ListDepartments()
        {
            var departments = from d in db.oddzialies
                               select d.nazwa;

            List<string> departmentsList = departments.ToList();

            return departmentsList;
        }

        public List<string> ListRooms()
        {
            var rooms = from r in db.pokojes
                        select r.nr;

            List<string> roomsList = rooms.ToList();

            return roomsList;
        }

        public string getRoom(int number)
        {
            string room = (from d in db.oddzialies
                                 where d.id_oddzialu == number
                                 select d.nazwa).First().ToString();

            return room;
        }

        public List<string> getEmployeesNamesList()
        {
            var names = from e in db.pracownicies
                        select e.imie;

            List<string> namesList = names.ToList();

            return namesList;
        }

        public List<string> getEmployeesSurnamesList()
        {
            var surnames = from e in db.pracownicies
                        select e.nazwisko;

            List<string> surnamesList = surnames.ToList();

            return surnamesList;
        }

        public List<string> getEmployeesProfessionsList()
        {
            var professions = from e in db.pracownicies
                           select e.zawod;

            List<string> professionsList = professions.ToList();

            return professionsList;
        }

        public string getEmployeeName(int id)
        {
            string name = (from d in db.pracownicies
                           where d.id_pracownika == id
                           select d.imie).First().ToString();

            return name;
        }

        public string getEmployeeSurname(int id)
        {
            string surname = (from d in db.pracownicies
                           where d.id_pracownika == id
                           select d.nazwisko).First().ToString();

            return surname;
        }

        public string getEmployeeProfession(int id)
        {
            string profession = (from d in db.pracownicies
                              where d.id_pracownika == id
                              select d.zawod).First().ToString();

            return profession;
        }

        public List<string> getPatientNamesList()
        {
            var names = from p in db.pacjencis
                              select p.imie;

            List<string> namesList = names.ToList();

            return namesList;
        }

        public List<string> getPatientSurnamesList()
        {
            var surnames = from p in db.pacjencis
                        select p.nazwisko;

            List<string> surnamesList = surnames.ToList();

            return surnamesList;
        }

        public List<string> getPatientDiseasesList()
        {
            var diseases = from p in db.pacjencis
                           select p.choroba;

            List<string> diseasesList = diseases.ToList();

            return diseasesList;
        }

        public string getPatientName(int id)
        {
            string name = (from p in db.pacjencis
                                 where p.id_pacjenta == id
                                 select p.imie).First().ToString();

            return name;
        }

        public string getPatientSurame(int id)
        {
            string surname = (from p in db.pacjencis
                           where p.id_pacjenta == id
                           select p.nazwisko).First().ToString();

            return surname;
        }

        public string getPatientDisease(int id)
        {
            string disease = (from p in db.pacjencis
                              where p.id_pacjenta == id
                              select p.choroba).First().ToString();

            return disease;
        }

    }
}
