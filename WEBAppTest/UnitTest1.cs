using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
namespace WEBAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getNameTests()
        {
            Test.Test abc = new Test.Test();
            // Assert.IsTrue(true);
            Assert.AreEqual("Krishan", abc.getName());
        }

        [TestMethod]
        public void getNameTests1()
        {
            Test.Test abc1 = new Test.Test();
            // Assert.IsTrue(true);
            Assert.AreEqual("Nagendra", abc1.getName1());
        }

        [TestMethod]
        public void Add()
        {
            //Assert.IsTrue(true);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void GetDetails()
        {
            //Assert.IsTrue(true);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void GetAct()
        {
           // Assert.IsTrue(true);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void EditValue()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void EditValue1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SetValue()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Allow()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestMethod12()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Added()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void GetDetailsdata()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void GetActEMP()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void EditValueofEMP()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void EditValueofData()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SetValueABC()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void AllowTodelete()
        {
            Assert.IsTrue(true);
        }
    }
}
