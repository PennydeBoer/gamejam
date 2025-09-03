using UnityEngine;

public class TentacleHit : MonoBehaviour
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerObject)
        {
            enemy.TakeDamage();
        }
    }
}
