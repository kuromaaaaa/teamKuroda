using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /// <summary>
    /// シーンをロードするやつ UnityEventなどで呼んで
    /// </summary>
    /// <param name="sceneName"></param>
    public void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
