using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemies : MonoBehaviour
{
    private GameObject playerObject;
    private PlayerObject player;
    void Start()
    {
        playerObject = GameObject.Find("player");
        player = playerObject.GetComponent<PlayerObject>();
       
    }

    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerObject )
        {
            
        }
    }
}
