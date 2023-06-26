using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressbarScript : MonoBehaviour
{
    public static int index;
    public Scrollbar scrollbar;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;


        scrollbar.size = 0f;
        InvokeRepeating("LoadBar", 0, 1.0f);

        StartCoroutine(LoadAsync(index));



        
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;
        yield return null;
    }


    void LoadBar()
    {
        if(scrollbar.size<1)
        {
            scrollbar.size += Random.Range(0.01f, 0.2f);
        }
        else
        {
            SceneManager.LoadScene(index);
        }
    }
}
