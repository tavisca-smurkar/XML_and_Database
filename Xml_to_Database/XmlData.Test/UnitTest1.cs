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
                bool result = ValidationClass.ValidateCompanyId("0");
                Assert.AreEqual(result, true);
            }
            catch (Exception e)
            {
                string str = e.Message;
            }
        }



        [TestMethod]
        public void TestForName()
        {
            try
            {
                bool result = ValidationClass.ValidCompanyName("12abc");
                Assert.AreEqual(result, true);
            }
            catch (Exception e)
            {
                string str = e.Message;
            }
        }
    }
}
