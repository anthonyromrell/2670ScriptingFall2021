using System;
using UnityEngine;

public class CollectionBehaviour : MonoBehaviour
{
    public CollectableSO collectedObj;
    public CollectionSO collection;

    private void Start()
    {
        EnableDisableCollectable(!collectedObj.collected);
    }

    private void OnTriggerEnter(Collider other)
    {
        collection.Collect(collectedObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value)
    {
        GetComponent<MeshRenderer>().enabled = value;
        GetComponent<Collider>().enabled = value;
    }
}
