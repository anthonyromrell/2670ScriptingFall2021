using System.Collections;
using UnityEngine;

public class DestroyerBehaviour : MonoBehaviour
{
    public IntData modValueObj;
    public bool canSelfDestruct;
    public float holdTime = 2f;
    public int value;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        if (canSelfDestruct)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        CheckValue();
    }

    private void CheckValue()
    {
        while (true)
        {
            if (value <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                value -= modValueObj.value;
                continue;
            }
            break;
        }
    }
}