using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
        [TestFixture]
        public class Tests
        {
         [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person Juan = new Person("Juan Gambetta", "5072451-7", "05/06/2000");
            string expected = "Juan Gambetta";
            Assert.AreEqual(expected, Juan.Name);
        }  
         [Test]
        public void TestID()
        {
            Person Juan = new Person("Juan Gambetta", "5.072.451-5", "05/06/2000");
            string expected = null;
            Assert.AreEqual(expected, Juan.ID);
        } 
        public void TestFecha()
        {
            Person Juan = new Person("Juan Gambetta", "5.072.451-5", "05/06/2000");
            string expected = "05/06/2000";
            Assert.AreEqual(expected, Juan.Fecha);
        } 
        }
}