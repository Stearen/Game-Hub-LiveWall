using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBuilder : MonoBehaviour
{

    public GameObject ShopManager;
    public int ItemID;
    public IDManager IDmanager;


    public void backing()
    {
        ItemID = IDmanager.Number;
        ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID] += 1;
        ItemID = 0;
    }

}
