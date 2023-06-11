using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlaces : MonoBehaviour
{
    public Transform PlaceBoxes;

    private void OnEnable()
    {
        PlaceBoxes.localPosition = new Vector2(0, -Screen.height);
        PlaceBoxes.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }

    public void CloseBox()
    {
        PlaceBoxes.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }



}
