using System.Collections.Generic;

public class Player {
    
    private Deck _activeDeck;
    private List<Card> _cards = new List<Card>();

    public Player(Deck d){
        _activeDeck = d;
    }

    public void Hit(){
        _cards.Add(_activeDeck.GetNextCard());
    }

    public int GetTotalValue(){
        int total = 0;
        foreach(Card c in _cards){
            if(c.Face == Face.Ace){
                if(total > 10)
                    total += 1;
                else
                    total += 11;
            } else if(c.Face == Face.Jack || c.Face == Face.Queen || c.Face == Face.King){
                    total += 10;
            } else {
                total += (int) c.Face;
            }
        }
        return total;
    }

}