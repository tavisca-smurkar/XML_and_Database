using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xml_to_Database;

namespace XmlData.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForCompanyID()
        {
            try
            {
              bool result =   ValidationClass.ValidateCompany("0");
                Assert.AreEqual(result, true);
            }
            catch (Exception e)
            {
                string str = e.Message;
            }
        }
    }
}
