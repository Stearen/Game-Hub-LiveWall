using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseOpenPage : MonoBehaviour
{
    public GameObject PageOne;
    public GameObject PageTwo;

    public void OpenClose()
    {
        PageOne.SetActive(false);
        PageTwo.SetActive(true);

    }



}
