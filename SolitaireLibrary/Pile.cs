namespace SolitaireLibrary
{
    public class Pile : iPile
    {
        //list of cards
        public List<Card> CardList { get; set; } = new List<Card>();

        public Pile()
        {
        }        

        public virtual bool AddCard(Card card)
        {
            if (card.isFaceUp == false) return false;
            CardList.Add(card);
            return true;
        }
    }
}