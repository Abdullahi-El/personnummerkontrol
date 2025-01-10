using NUnit.Framework;
using PersonnummerKontroll; // Här importerar vi PersonnummerKontroll-namnområdet för att kunna använda Program-klassen

namespace PersonnummerKontroll.Tests
{
    public class Tests
    {
        // Setup-metoden kan vara tom om du inte behöver några förberedelser innan varje test
        [SetUp]
        public void Setup()
        {
        }

        // Testfall 1: Kontrollera ett korrekt personnummer
        [Test]
        public void TestKorrektPersonnummer()
        {
            string korrektPersonnummer = "8901011234"; // Exempel på korrekt personnummer
            Assert.IsTrue(Program.VerifieraPersonnummer(korrektPersonnummer));
        }

        // Testfall 2: Kontrollera ett felaktigt personnummer
        [Test]
        public void TestFelaktigtPersonnummer()
        {
            string felaktigtPersonnummer = "8901011235"; // Exempel på felaktigt personnummer
            Assert.IsFalse(Program.VerifieraPersonnummer(felaktigtPersonnummer));
        }

        // Testfall 3: Kontrollera ett för kort personnummer
        [Test]
        public void TestKortPersonnummer()
        {
            string kortPersonnummer = "89010112"; // För kortt personnummer
            Assert.IsFalse(Program.VerifieraPersonnummer(kortPersonnummer));
        }

        // Testfall 4: Kontrollera ett personnummer med bindestreck
        [Test]
        public void TestPersonnummerMedBindestreck()
        {
            string personnummerMedBindestreck = "890101-1234"; // Exempel på personnummer med bindestreck
            Assert.IsTrue(Program.VerifieraPersonnummer(personnummerMedBindestreck));
        }
    }
}
