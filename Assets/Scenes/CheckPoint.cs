using UnityEngine;

public class CheckPoint : MonoBehaviour
{
     public Vector2[] points =
     {
        new Vector2(0,0),
        new Vector2(2,0),
        new Vector2(4,0)
    };

     void Start()
     {
          for (int i = 0; i < points.Length; i++)
          {
               Debug.Log(points[i]);
          }
     }
}