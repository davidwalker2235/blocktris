using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoButtonScript : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("Credits");
    }
}
