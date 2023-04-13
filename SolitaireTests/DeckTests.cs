using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolitaireLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolitaireTests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void DeckShouldBeCreated()
        {
            Deck deck = new Deck();
            Assert.IsNotNull(deck);
            Assert.AreEqual(deck.Cards.Count, 52);
            
        }
        [TestMethod]
        public void CardsInTheDeckShouldBeUnique()
        {
            Deck deck = new Deck();
            Assert.IsFalse(deck.Cards.Count != deck.Cards.Distinct<Card>().Count());
        }
    }
}
