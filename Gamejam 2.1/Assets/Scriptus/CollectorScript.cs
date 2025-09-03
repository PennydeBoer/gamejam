using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] private PointsManagerScript pointsManager;
    private Enemies enemy;
    private void Start()
    {
        enemy = GameObject.Find("tentacle").GetComponent<Enemies>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pointsManager.manaPoints += 1;
            enemy.ManaText.text = "Moons: " +pointsManager.manaPoints + "/8";
            Destroy(gameObject);
        }
    }
}
