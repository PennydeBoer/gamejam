using Unity.VisualScripting;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= -1)
        {
            Destroy(gameObject);
        }
    }
}
