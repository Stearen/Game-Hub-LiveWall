using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBuildBox : MonoBehaviour
{
    public Transform Box;
    public CanvasGroup Background;


    private void OnEnable()
    {
        Background.alpha = 0;
        Background.LeanAlpha(1, 0.5f);

        Box.localPosition = new Vector2(0, -Screen.height);
        Box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }

    public void CloseBox()
    {
        Background.LeanAlpha(0, 0.5f);
        Box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo().setOnComplete(OnComplete);


    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }



}
