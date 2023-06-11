using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class PointManager
{


    public static int Points;

    public static void AddPoints(int Amount)
    {
        Points += Amount;
        UIRenderPoints();
    }

    public static bool RemovePoints(int Amount)
    {
        if (Points < Amount) 
        { 
            return false;
        }
        Points -= Amount;
        UIRenderPoints();
        return true;
    }

    public static void UIRenderPoints() 
    {
       List<GameObject> UiElements = new(GameObject.FindGameObjectsWithTag("ItemPointsUI"));
        foreach (GameObject UiElement in UiElements) 
        {
            UiElement.GetComponent<TextMeshProUGUI>().text = Points.ToString();       
        }
    }

}
