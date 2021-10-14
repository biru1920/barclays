using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using ThirdPartyTools;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory(TestCategory.UnitTest)]
        public void Version_Success()
        {
            string[] a = { "-v" , "C:/test.txt" };
             
            FileDetails fileDetails = new FileDetails();
           var b = fileDetails.Version(a[0]);
           Assert.AreNotEqual("-v",b);
        }

        [TestMethod]
        [TestCategory(TestCategory.UnitTest)]
        public void Version_Fail()
        {
            string[] a = { "-v", "C:/test.txt" };

            FileDetails fileDetails = new FileDetails();
            var b = fileDetails.Version(a[0]);
            Assert.AreNotEqual("-c", b);
            
        }

        [TestMethod]
        [TestCategory(TestCategory.UnitTest)]
        public void Size_Success()
        {
            string[] a = { "-v", "C:/test.txt" };

            FileDetails fileDetails = new FileDetails();
            var b = fileDetails.Size(a[1]);
            Assert.AreNotEqual("-v", b);
        }

        [TestMethod]
        [TestCategory(TestCategory.UnitTest)]
        public void Size_Fail()
        {
            string[] a = { "-v", "C:/test.txt" };

            FileDetails fileDetails = new FileDetails();
            var b = fileDetails.Size(a[1]);
            Assert.AreNotEqual("-c", b);

        }
    }
}
