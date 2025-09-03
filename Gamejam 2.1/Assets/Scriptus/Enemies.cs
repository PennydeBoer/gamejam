using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using Unity.Mathematics;
using System.Collections.Generic;


public class Enemies : MonoBehaviour
{
    [SerializeField] private GameObject raindrop;
    [SerializeField] private GameObject raindrop1;
    [SerializeField] private List<Image> Health;
    public Text ManaText;
    private int i = 0;
    private bool lastHit = false;

    void Start()
    {
        InvokeRepeating("SpawnRaindrop", 1f, 0.5f);        
    }
    

    private void SpawnRaindrop()
    {
        GameObject drop = Instantiate(raindrop1, new Vector3(Random.Range(-198.4f, 19.5f), 50, Random.Range(-156.9f, 24f)), Quaternion.identity);
        GameObject dropleft = Instantiate(raindrop, new Vector3(Random.Range(-198.4f, -61.4f), 50, Random.Range(-34.4f, -3.5f)), Quaternion.identity);
        GameObject dropright = Instantiate(raindrop, new Vector3(Random.Range(-61.4f, 19.5f), 50, Random.Range(-156.9f, -22.2f)), Quaternion.identity);
        GameObject drop1 = Instantiate(raindrop1, new Vector3(Random.Range(-198.4f, 19.5f), 50, Random.Range(-156.9f, 24f)), Quaternion.identity);
        GameObject drop1left = Instantiate(raindrop1, new Vector3(Random.Range(-198.4f, -61.4f), 50, Random.Range(-34.4f, -3.5f)), Quaternion.identity);
        GameObject drop1right = Instantiate(raindrop1, new Vector3(Random.Range(-61.4f, 19.5f), 50, Random.Range(-156.9f, -22.2f)), Quaternion.identity); 
        GameObject drop2 = Instantiate(raindrop1, new Vector3(Random.Range(-198.4f, 19.5f), 50, Random.Range(-156.9f, 24f)), Quaternion.identity);
        GameObject drop2left = Instantiate(raindrop1, new Vector3(Random.Range(-198.4f, -61.4f), 50, Random.Range(-34.4f, -3.5f)), Quaternion.identity);
        GameObject drop2right = Instantiate(raindrop1, new Vector3(Random.Range(-61.4f, 19.5f), 50, Random.Range(-156.9f, -22.2f)), Quaternion.identity);
    }
    public void TakeDamage()
    {
        if (i >= Health.Count)
        {
            SceneManager.LoadScene(1);
            return;
        }
        if (!lastHit)
        {
            Destroy(Health[i]);
            i++;
            lastHit = true;
            Invoke("ResetHit", 1f);
        }
    }
    private void ResetHit()
    {
        lastHit = false;
    }

}
