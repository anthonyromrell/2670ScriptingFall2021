using UnityEngine;

public abstract class CharacterBase : ScriptableObject
{
    public Color skinColor = Color.gray;

    public virtual void Walk()
    {
        Debug.Log("Walking");
    }
}
