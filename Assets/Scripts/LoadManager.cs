using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadManager : MonoBehaviour
{
    public string sceneToLoad = "game";
    public void LoadGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
