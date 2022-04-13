using UnityEngine;
using UnityEngine.Events;

public class MouseEventsBehaviour : MonoBehaviour
{
   public UnityEvent mouseDownEvent;

   private void OnMouseDown()
   {
      Debug.Log("Fire");
      mouseDownEvent.Invoke();
   }
}
