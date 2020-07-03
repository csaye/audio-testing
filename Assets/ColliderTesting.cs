using UnityEngine;

public class ColliderTesting : MonoBehaviour
{   
    Vector2 centerPosition = new Vector2(0.8f, 0.5f);
    Vector2 size = new Vector2(0.5f, 0.5f);

    void Start()
    {
        Debug.Log(Physics2D.OverlapBox(centerPosition, size, 0));
        // returns null despite one-block square collider at 0,0
    }
}
