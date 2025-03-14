namespace TestyKonto
{
    [TestClass]
    public class KontoDzialania
    {
        [TestMethod]
        public void Konstruktor()
        {
            var person = new Bank.Konto("Ivanka", 10000);
            Assert.AreEqual(person.Nazwa, "Ivanka");
            Assert.AreEqual(person.Bilans, 10000);
            Assert.IsFalse(person.Zablokowane);
        }
    }
}