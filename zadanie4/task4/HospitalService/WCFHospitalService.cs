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
        public List<string> listDepartments()
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

        public string showDepartment(int id)
        {
            Console.WriteLine("showDepartment(id = " + id +") zostala wywolana przez klienta");

            string department;

            using (szpitalEntities database = new szpitalEntities())
            {
                var departments = from o in database.oddzialy
                                  where o.id_oddzialu == id
                                  select o.nazwa;

                department = departments.First();
                return department;
            }
        }

        public void removeDepartment(int id)
        {
            Console.WriteLine("removeDepartment(id = " + id + ") zostala wywolana przez klienta");

            using (szpitalEntities database = new szpitalEntities())
            {
                var departments = database.oddzialy.Where(x => x.id_oddzialu == id).FirstOrDefault();

                if(departments != null)
                {
                    database.oddzialy.Remove(departments);
                    database.SaveChanges();
                }
            }
        }

        public List<string> listRooms()
        {
            Console.WriteLine("ListRooms() zostala wywolana przez klienta");

            List<string> roomsList = new List<string>();

            using (szpitalEntities database = new szpitalEntities())
            {
                var rooms = from r in database.pokoje
                            select r.nr;

                roomsList = rooms.ToList();
            }

            return roomsList;
        }

        public List<string> listPatients()
        {
            Console.WriteLine("listPatients() zostala wywolana przez klienta");

            List<string> patientsList = new List<string>();

            using (szpitalEntities database = new szpitalEntities())
            {
                foreach(var p in database.pacjenci)
                {
                    patientsList.Add(p.imie + " " + p.nazwisko + " choroba: " + p.choroba);
                }
            }

            return patientsList;
        }

        public string showPatient(int id)
        {
            Console.WriteLine("showPatient(id = "+id+") zostala wywolana przez klienta");

            using (szpitalEntities database = new szpitalEntities())
            {
                foreach (var p in database.pacjenci)
                {
                    if(p.id_pacjenta == id)
                    {
                        return p.imie + " " + p.nazwisko + " choroba: " + p.choroba;
                    }
                }
            }
            return "brak danych";
        }

        public List<string> listEmployees()
        {
            Console.WriteLine("listEmployees() zostala wywolana przez klienta");

            List<string> employeesList = new List<string>();

            using (szpitalEntities database = new szpitalEntities())
            {
                foreach (var e in database.pracownicy)
                {
                    employeesList.Add(e.imie + " " + e.nazwisko + " zawód: " + e.zawod);
                }
            }

            return employeesList;
        }

        public string showEmployee(int id)
        {
            Console.WriteLine("showEmployee(id = " + id + ") zostala wywolana przez klienta");

            using (szpitalEntities database = new szpitalEntities())
            {
                foreach (var e in database.pracownicy)
                {
                    if (e.id_pracownika == id)
                    {
                        return e.imie + " " + e.nazwisko + " zawód: " + e.zawod;
                    }
                }
            }
            return "brak danych";
        }
    }
}
