namespace SolitaireLibrary
{
    public class TalonPile : iPile
    {
        public TalonPile()
        {
            CardList = new List<Card>();
        }

        public List<Card> CardList { get; set; }

        public bool AddCard(Card card)
        {
            if(!card.isFaceUp) return false;    
            CardList.Add(card);
            return true;
        }
    }
}