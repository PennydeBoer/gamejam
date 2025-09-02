using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using Unity.Mathematics;


public class Enemies : MonoBehaviour
{
    [SerializeField] private GameObject raindrop;
    private GameObject playerObject;
    private PlayerObject player;
    private GameObject drop;
    public Text healthtext;
    
    void Start()
    {
        playerObject = GameObject.Find("Player");
        player = playerObject.GetComponent<PlayerObject>();
        InvokeRepeating("SpawnRaindrop", 1f, 0.5f);        
    }
    

    private void SpawnRaindrop()
    {
        drop = Instantiate(raindrop, new Vector3(Random.Range(-10f, 10f), 50, Random.Range(-10f, 10f)), Quaternion.identity);
    }
   
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playerObject) 
        {
            player.Health -= 10;
            healthtext.text = "Health = " + player.Health;  
        }
        
    }
}
