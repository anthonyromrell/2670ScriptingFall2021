using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class CardHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    private SpriteRenderer spriteRendererObj;
    
    private void Start()
    {
        spriteRendererObj = GetComponent<SpriteRenderer>();
        gameActionObj.raise += Raise;
    }

    private void Raise(object cardObj)
    {
        var newCard = cardObj as Card;
        spriteRendererObj.sprite = newCard.art;
        spriteRendererObj.color = newCard.color;
    }
}
