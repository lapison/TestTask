using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public int nextscene;
    public static Texture textureLoad;
    public void LoadScene(int sceneID)
    {
        ProgressbarScript.index = nextscene;
        SceneManager.LoadScene(sceneID);
    }
}
