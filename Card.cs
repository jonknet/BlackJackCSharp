public class Card {

    private Face _face;
    private Suit _suit;
    private int _value;

    public Card(Face face, Suit suit, int value) {
        _face = face;
        _suit = suit;
        _value = value;
    }

    public int Value {
        get {
            return _value;
        }
    }

    public Face Face {
        get {
            return _face;
        }
    }

    public Suit Suit {
        get {
            return _suit;
        }
    }

    public override string ToString()
    {
        string str = "";

        switch(_face){
            case Face.Two:
                str += "2"; break;
            case Face.Three:
                str += "3"; break;
            case Face.Four:
                str += "4"; break;
            case Face.Five:
                str += "5"; break;
            case Face.Six:
                str += "6"; break;
            case Face.Seven:
                str += "7"; break;
            case Face.Eight:
                str += "8"; break;
            case Face.Nine:
                str += "9"; break;
            case Face.Ten:
                str += "10"; break;
            case Face.Jack:
                str += "J"; break;
            case Face.Queen:
                str += "Q"; break;
            case Face.King:
                str += "K"; break;
            case Face.Ace:
                str += "A"; break;
        }
        switch(_suit){
            case Suit.Heart:
                str += "H"; break;
            case Suit.Diamond:
                str += "D"; break;
            case Suit.Spade:
                str += "S"; break;
            case Suit.Club:
                str += "C"; break;
        }        

        return str;
    }
}