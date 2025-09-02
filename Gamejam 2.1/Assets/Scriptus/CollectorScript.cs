using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] private PointsManagerScript pointsManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pointsManager.manaPoints += 1;
            Destroy(gameObject);
        }
    }
}
