using UnityEngine;

public interface IPowerUp
{
    public float PowerLevel { get; set; }
}

public interface IPool
{
    public void AddToPool(GameObject obj);
}