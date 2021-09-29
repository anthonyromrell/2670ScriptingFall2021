using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public IntData intDataObj;

    private void OnTriggerEnter(Collider other)
    {
        intDataObj.value++;
    }
}
