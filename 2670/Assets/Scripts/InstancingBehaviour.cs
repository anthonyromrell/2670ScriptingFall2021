using UnityEngine;

public class InstancingBehaviour : MonoBehaviour
{
    public void OnInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
