using System.Collections.Generic;
using System;
using System.Linq;

public class Deck {

    private List<Card> _cards;
    private int _numberOfDecks;

    public Deck(int numberOfDecks){
        _cards = new List<Card>();
        _numberOfDecks = numberOfDecks;
        InitializeDeck();
        Shuffle();
    }

    private void InitializeDeck(){
        List<Face> faces = Enum.GetValues(typeof(Face))
            .Cast<Face>()
            .ToList();
        List<Suit> suits = Enum.GetValues(typeof(Suit))
            .Cast<Suit>()
            .ToList();
        for(int i = 0; i < _numberOfDecks; i++){
            for(int j = 0; j < suits.Count; j++){
                for(int k = 0; k < faces.Count; k++){
                    if(faces[k] == Face.Jack || faces[k] == Face.Queen || faces[k] == Face.King){
                        _cards.Add(new Card(faces[k],suits[j],10));
                    } else {
                        _cards.Add(new Card(faces[k],suits[j],(int)faces[k]));
                    }
                }
            }
        }
    }

    private void Shuffle(){
        Random rnd = new Random();
        for(int i = 0; i < _cards.Count; i++){
            _cards.Insert(rnd.Next(_cards.Count+1),_cards[0]);
            _cards.RemoveAt(0);
        }
    }

    public Card GetNextCard(){
        if(_cards.Count == 0){
            InitializeDeck();
            Shuffle();
        }
        Card c = _cards[0];
        _cards.RemoveAt(0);
        return c;
    }

    public string ToString(){
        string str = "";
        foreach(Card c in _cards){
            str += c.ToString() + " ";
        }
        return str;
    }
}