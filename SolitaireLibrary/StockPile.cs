namespace SolitaireLibrary
{
    public class StockPile : Pile
    {
        public StockPile()
        {
            CardList = new List<Card>();
        }

        override public bool AddCard(Card card)
        {
            return false;
        }

        public void Move(Pile movePile, Pile fromPile, Pile toPile)
        {
            throw new NotImplementedException();
        }
    }
}