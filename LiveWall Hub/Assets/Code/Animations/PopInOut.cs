using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopInOut : MonoBehaviour
{
    public Transform InOut;

    public void OnEnable()
    {
        InOut.LeanScale(Vector2.one, 1f).setEaseInBack();
    }

    public void Close()
    {
        InOut.LeanScale(Vector2.zero, 1f).setEaseInBack().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }
}
