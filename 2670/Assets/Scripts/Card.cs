using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public Sprite art;
    public Color color = Color.blue;

    public void ChangeSpriteRender(SpriteRenderer obj)
    {
        obj.sprite = art;
        obj.color = color;
    }
}
