using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject tentacleObject;
    private bool spawned = false;
    private void SpawnTentacle()
    {
        GameObject tentacle = Instantiate(tentacleObject, gameObject.transform.position, Quaternion.identity);
        spawned = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && !spawned) { 
        SpawnTentacle();}
    }
}
