namespace SolitaireLibrary
{
    public class DeckPile
    {
        public List<Card> Cards { get; set; }

        public DeckPile()
        {
            //Add comment for test Push
            Cards = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for(int j = 1; j < 14; j++)
                Cards.Add(new Card(j, (SuitType)i));
            }
        }
        public void Shuffle()
        {
            
        }
    }
}