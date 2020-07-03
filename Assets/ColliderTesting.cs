using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTesting : MonoBehaviour
{
    public Vector2 centerPos;
    public Vector2 size;
    
    [Space]
    public GameObject colliderRepresentation;

    void Update()
    {
        colliderRepresentation.transform.position = centerPos;
        colliderRepresentation.transform.localScale = new Vector3(size.x * 2, size.y * 2, 1);

        if (Input.GetKeyDown("space"))
        {
            // foreach (Collider2D col in Physics2D.OverlapBoxAll(centerPos, size, 0))
            // {
            //     Debug.Log(col.gameObject);
            // }
            foreach (Collider2D col in Physics2D.OverlapAreaAll(new Vector2(centerPos.x - size.x, centerPos.y - size.y), new Vector2(centerPos.x + size.x, centerPos.y + size.y)))
            {
                Debug.Log(col.gameObject);
            }
        }
    }
}
