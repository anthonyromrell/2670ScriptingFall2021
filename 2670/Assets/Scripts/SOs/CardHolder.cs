using UnityEngine;

[CreateAssetMenu]
public class CardHolder : ScriptableObject
{
    public Card cardObj;
    public GameAction gameActionObj;

    public void ChangeCard(Card newCardObj)
    {
        cardObj = newCardObj;
    }
    
    public void RaiseAction()
    {
        gameActionObj.raise(cardObj);
    }
}
