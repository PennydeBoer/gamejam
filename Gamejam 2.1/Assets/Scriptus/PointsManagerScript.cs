using UnityEngine;
using static UnityEngine.UI.Image;

public class PointsManagerScript : MonoBehaviour
{
    [SerializeField] GameObject Beam;
    [SerializeField] GameObject TargetPossition;
    public int manaPoints = 0;


    void Update()
    {
        if (manaPoints > 10)
        {
            Instantiate(Beam, TargetPossition.transform);
        }
    }
}
