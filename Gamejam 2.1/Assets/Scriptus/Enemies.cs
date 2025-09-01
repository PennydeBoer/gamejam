using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

using Unity.Mathematics;


public class Enemies : MonoBehaviour
{
    [SerializeField] private GameObject raindrop;
    private GameObject playerObject;
    private PlayerObject player;
    GameObject drop;
    void Start()
    {
        playerObject = GameObject.Find("player");
        player = playerObject.GetComponent<PlayerObject>();
        if (gameObject.tag == "Droplet"  ) {
            InvokeRepeating("SpawnRaindrop", 1f, 3f);
        }
    }
    

    private void SpawnRaindrop()
    {
        drop = Instantiate(raindrop, new Vector3(Random.Range(1f, 10f), 10, Random.Range(1f, 10f)), Quaternion.identity);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerObject )
        {
            
        }
    }
}
