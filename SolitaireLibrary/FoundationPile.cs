namespace SolitaireLibrary
{
    public class FoundationPile : iPile
    {
        public FoundationPile()
        {

        }

        public List<Card> CardList { get; set; } = new List<Card>();

        public bool AddCard(Card card)
        {
            CardList.Add(card);
            return true;    
        }
    }
}