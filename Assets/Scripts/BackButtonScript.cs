using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Cover");
    }
}
