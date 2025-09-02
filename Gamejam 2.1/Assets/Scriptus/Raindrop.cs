using Unity.VisualScripting;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    private Enemies enemy;
    private GameObject playerObject;
    private PlayerObject player;
    private void Start()
    {
        enemy = GameObject.Find("tentacle").GetComponent<Enemies>();
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<PlayerObject>();
    }
    void Update()
    {
        if (transform.position.y <= -1)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerObject)
        {
            player.Health -= 10;
            //enemy.healthtext.text = "Health = " + player.Health;
        }
        else
        {
            Invoke("DespawnRaindrops", 0.2f);
        }
    }
    private void DespawnRaindrops()
    {
        Destroy(gameObject);
    }
}
