using System.Collections.Generic;

public class Hand {

    private List<Card> _cards = new List<Card>();

    public void AddCard(Card c){
        _cards.Add(c);
    }

    public int GetTotalValue(){
        int total = 0;
        foreach(Card c in _cards){
            if(c.Face == Face.Ace){
                if(total > 10)
                    total += 1;
                else
                    total += 11;
            } else {
                total += (int) c.Face;
            }
        }
        return total;
    }

}