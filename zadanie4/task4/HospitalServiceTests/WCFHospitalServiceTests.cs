using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HospitalService.Tests
{
    [TestClass()]
    public class WCFHospitalServiceTests
    {
        [TestMethod()]
        public void listDepartmentsTest()
        {
            ChannelFactory<IWCFHospitalService> channelFactory;
            channelFactory = new ChannelFactory<IWCFHospitalService>("HospitalServiceEndpoint");

            IWCFHospitalService proxy = channelFactory.CreateChannel();
            List<string> departmentsList = new List<string>();

            departmentsList = proxy.listDepartments();

            Assert.AreEqual(departmentsList.Count, 4);

        }
    }
}