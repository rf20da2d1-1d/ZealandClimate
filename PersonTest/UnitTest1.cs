using DataStrukturer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            Person pers1 = new Person(2, "Peter");
            Person pers2 = new Person(2, "Peter");

            // act

            // assert
            Assert.AreEqual(pers1, pers2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            Person pers1 = new Person(2, "Peter");
            Person pers2 = new Person(2, "Peter");
            // act

            // assert
            Assert.AreNotSame(pers1, pers2);
        }


        [TestMethod]
        public void TestMethod3()
        {
            // arrange
            Person pers1 = new Person(2, "Peter");
            Person pers2 = pers1;
            // act

            // assert
            Assert.AreSame(pers1, pers2);
            Assert.AreEqual(pers1, pers2);

        }
    }
}
