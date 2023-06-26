using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoinScript : MonoBehaviour, IPointerClickHandler
{
    public Renderer GoldCoin;

    private void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        var r = Random.Range(0f, 1f);
        var g = Random.Range(0f, 1f);
        var b = Random.Range(0f, 1f);
        GoldCoin.material.SetColor("_Color", new Color(r, g, b, 1f));

    }
}
