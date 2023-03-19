using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingChanger : MonoBehaviour
{
    public void ChangingSceneEvent()
    {
        SceneManager.LoadScene(1);
    }
}