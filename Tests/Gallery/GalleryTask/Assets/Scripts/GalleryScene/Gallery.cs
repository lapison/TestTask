using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Gallery : MonoBehaviour
{
    public RectTransform ContentForms;
    public RawImage rw;
    public string url;
    int i = 1;
    bool isLoadNext = true;




    private void Start()
    {

        InvokeRepeating("chk", 0, 0.3f);

    }


    void chk()
    {
        int height = (int)(ContentForms.sizeDelta.y * ContentForms.localScale.y);
        int y = (int)(ContentForms.offsetMax.y);
        int x = height - y;
        if (x <= 2000 && isLoadNext)
        {
            StartCoroutine(LoadFromInternet(url));
        }
    }

    private IEnumerator LoadFromInternet(string url)
    {

        var req = UnityWebRequestTexture.GetTexture(url + i + ".jpg");
        i++;
        yield return req.SendWebRequest();
        if(!req.isNetworkError && !req.isHttpError)
        {
            RawImage newrw = Instantiate(rw, ContentForms);
            newrw.texture = DownloadHandlerTexture.GetContent(req);
        }
        else
        {
            isLoadNext = false;
        }
        

        /*if(i!=7)
        {
            RawImage newrw = Instantiate(rw, ContentForms);

            newrw.texture = DownloadHandlerTexture.GetContent(req);

            StartCoroutine(LoadFromInternet(url, ++i));
        }*/
    }

}
