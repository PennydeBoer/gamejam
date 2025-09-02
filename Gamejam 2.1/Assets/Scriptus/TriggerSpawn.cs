using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject tentacleObject;
    private bool spawned = false;
    private Animator animator;
    private Collider collider;
    
    private void Start()
    {
        collider = tentacleObject.GetComponent<Collider>();
        animator = tentacleObject.GetComponent<Animator>();

    }
    private void SpawnTentacle()
    {
        animator.SetTrigger("Animation");
        spawned = true;
        Invoke("EnableCollider", 1f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !spawned)
        {
            SpawnTentacle();
        }
    }
    private void EnableCollider()
    {
        collider.enabled=true;
        Invoke("DisableCollider", 1.17f);
    }
    private void DisableCollider()
    {
        collider.enabled = false;
    }
}
