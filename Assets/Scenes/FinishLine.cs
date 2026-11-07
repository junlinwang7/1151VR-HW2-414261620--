using UnityEngine;

public class FinishLine : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D other)
     {
          Debug.Log("You Win!");
     }
}