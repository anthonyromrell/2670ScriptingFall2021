using UnityEngine;

public class CollectionBehaviour : MonoBehaviour
{
    public CollectableSO collectedObj;
    void Start()
    {
        if (collectedObj.collected)
        {
            Destroy(gameObject);
        }
    }
}
