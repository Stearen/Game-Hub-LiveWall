using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDeleteItem : MonoBehaviour
{
    public GameObject Item;

    public void PlaceItem()
    {
        if (Item.activeInHierarchy == true)
            Item.SetActive(false);
        else
            Item.SetActive(true);
    }

}
