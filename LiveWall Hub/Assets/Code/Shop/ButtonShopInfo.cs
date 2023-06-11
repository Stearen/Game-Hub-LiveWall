using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class ButtonShopInfo : MonoBehaviour
{
    public int ItemID;
    public TextMeshProUGUI PriceTxt;
    public TextMeshProUGUI QuantityTxt;
    public GameObject ShopManager;
    public Animation Anime;
    


    // This script gives the button/item it's ID so the ShopManger knows how expensive it is, which text should change and keeps updating it so it's always correct. 
    // It also works together with the builder shop scripts. 
    void Update()
    {
        PriceTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();

        QuantityTxt.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();


    }



}
