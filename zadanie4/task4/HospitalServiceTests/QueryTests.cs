using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalService.Tests
{
    [TestClass()]
    public class QueryTests
    {
        [TestMethod()]
        public void getDepartmentTest()
        {
            Query query = new Query();
            string expected = "Gastroenterologia";
            string result;

            result = query.getDepartment(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ListDepartmentsTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string>{ "Gastroenterologia" };
            result = query.ListDepartments();

            Assert.AreEqual(expected[0], result[0]);

        }

        [TestMethod()]
        public void ListRoomsTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "101" };
            result = query.ListRooms();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getRoomTest()
        {
            Query query = new Query();
            string expected = "101";
            string result;

            result = query.getRoom("101");

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getEmployeesNamesListTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Edward" };
            result = query.getEmployeesNamesList();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getEmployeesSurnamesListTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Łącki" };
            result = query.getEmployeesSurnamesList();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getEmployeesProfessionsListTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Gastroenterolog" };
            result = query.getEmployeesProfessionsList();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getEmployeeNameTest()
        {
            Query query = new Query();
            string expected = "Edward";
            string result;

            result = query.getEmployeeName(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getEmployeeSurnameTest()
        {
            Query query = new Query();
            string expected = "Łącki";
            string result;

            result = query.getEmployeeSurname(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getEmployeeProfessionTest()
        {
            Query query = new Query();
            string expected = "Gastroenterolog";
            string result;

            result = query.getEmployeeProfession(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getPatientNamesListTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Jan" };
            result = query.getPatientNamesList();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getPatientSurnamesListTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "Abecki" };
            result = query.getPatientSurnamesList();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getPatientDiseasesListTest()
        {
            Query query = new Query();
            List<string> expected = new List<string>();
            List<string> result = new List<string>();

            expected = new List<string> { "polipy jelita grubego" };
            result = query.getPatientDiseasesList();

            Assert.AreEqual(expected[0], result[0]);
        }

        [TestMethod()]
        public void getPatientNameTest()
        {
            Query query = new Query();
            string expected = "Jan";
            string result;

            result = query.getPatientName(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getPatientSurnameTest()
        {
            Query query = new Query();
            string expected = "Abecki";
            string result;

            result = query.getPatientSurname(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getPatientDiseaseTest()
        {
            Query query = new Query();
            string expected = "polipy jelita grubego";
            string result;

            result = query.getPatientDisease(1);

            Assert.AreEqual(expected, result);
        }
    }
}