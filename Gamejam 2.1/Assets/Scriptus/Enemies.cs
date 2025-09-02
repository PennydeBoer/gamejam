using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using Unity.Mathematics;


public class Enemies : MonoBehaviour
{
    [SerializeField] private GameObject raindrop;
    public Text healthtext;
    public Text ManaText;
    
    void Start()
    {
        InvokeRepeating("SpawnRaindrop", 1f, 1f);        
    }
    

    private void SpawnRaindrop()
    {
        GameObject dropright = Instantiate(raindrop, new Vector3(Random.Range(-20f, 30.1f), 50, Random.Range(-48.4f, -34.4f)), Quaternion.identity);
        GameObject dropupper = Instantiate(raindrop, new Vector3(Random.Range(12.4f, 32.2f), 50, Random.Range(-34.4f, -3.5f)), Quaternion.identity);
        GameObject dropleft = Instantiate(raindrop, new Vector3(Random.Range(-17.5f, 22.8f), 50, Random.Range(-3.5f, 13.4f)), Quaternion.identity);
    }
}
