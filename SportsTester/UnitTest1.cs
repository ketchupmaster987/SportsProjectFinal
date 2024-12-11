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

        [TestMethod]
        public void TeamTests()
        {
            Player p = new Player();
            Player p2 = new Player();
            LeaguePlayer p3 = new LeaguePlayer() { Position = "Mid" };
            Team t = new Team();
            t.AddPlayer(p);
            t.AddPlayer(p3);

            Assert.IsTrue(t.ContainsPlayer(p));
            Assert.IsTrue(t.ContainsPlayer(p3));
            Assert.IsFalse(t.ContainsPlayer(p2));
        }

        [TestMethod]
        public void SportTests()
        {

            Team t1 = new Team() { Name = "T1 Gaming" };
            Team t2 = new Team();
            Sport eSports = new Sport() { Name = "League of Legends" };

            Player p1 = new Player();

            t1.AddPlayer(p1);

            eSports.AddTeam(t1);

            Assert.IsTrue(eSports.ContainsTeam(t1));
            Assert.IsFalse(eSports.ContainsTeam(t2));
        }

    }
}