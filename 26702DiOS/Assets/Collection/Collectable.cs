using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Collectable : ScriptableObject
{
    public Sprite art;
    public int price = 10;
    public bool collected;
}
