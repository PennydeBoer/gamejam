using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;

public class PointsManagerScript : MonoBehaviour
{
    [SerializeField] private GameObject Beam;
    [SerializeField] private GameObject TargetPossition;
    public int manaPoints = 0;
    [SerializeField] private int maxManaPoints = 5;
    private bool beamActive = false;


    void Update()
    {
        if (manaPoints == maxManaPoints && !beamActive)
        {
            Instantiate(Beam, TargetPossition.transform);
            beamActive = true;
            Invoke("Endgame", 2f);
        }
    }
    private void Endgame()
    {
        SceneManager.LoadScene(2);
    }
}
