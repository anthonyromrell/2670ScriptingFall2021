using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject, IPowerUp
{
    public float PowerLevel { get; set; }
}
