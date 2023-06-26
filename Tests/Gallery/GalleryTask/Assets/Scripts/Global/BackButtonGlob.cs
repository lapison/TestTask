using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonGlob : MonoBehaviour
{
    public int prevIndex;
    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            ProgressbarScript.index = prevIndex;
            SceneManager.LoadScene(1);
        }
    }

}
