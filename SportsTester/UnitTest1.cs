using SportsLibrary;

namespace SportsTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DefaultPersonName()
        {
            Person p = new Person();
            string expectedName = "person name";

            Assert.AreEqual(expectedName, p.Name);
        }

        [TestMethod]
        public void PersonIDIncrement()
        { 
            Person p1 = new Person();
            int idOne = p1.id;
            Person p2 = new Person();
            int idTwo = p2.id;

            Assert.AreNotEqual(idOne, idTwo);
            Assert.AreEqual(idOne + 1, idTwo);
        }
    }
}