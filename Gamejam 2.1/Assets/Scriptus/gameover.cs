using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene(0);
    }
}
