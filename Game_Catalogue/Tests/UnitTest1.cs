using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddGenre()
        {
            Genre genre = new Genre();
            genre.GenreName = "Action";

            Assert.AreEqual("Action", genre.GenreName);

        }
    }
}