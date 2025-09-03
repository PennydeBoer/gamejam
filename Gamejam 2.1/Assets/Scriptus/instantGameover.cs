using Unity.VisualScripting;
using UnityEngine;

public class instantGameover : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}

