using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject tentacleObject;
    
    private void SpawnTentacle()
    {
        GameObject tentacle = Instantiate(tentacleObject, gameObject.transform.position, Quaternion.identity);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") { 
        SpawnTentacle();}
    }
}
