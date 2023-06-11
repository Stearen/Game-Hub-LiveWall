using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5,5];
    public AudioSource audio;
   // public GameObject NotEnoughCoins;
    public Animation Animes;

    



    // this checks how many ID's there are, how much each ID is in price and how many of this item the user has. 
    void Start()
    {
        // ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 1;
        shopItems[1, 3] = 1;
        shopItems[1, 4] = 1;

        //Price
        shopItems[2, 1] = 200;
        shopItems[2, 2] = 350;
        shopItems[2, 3] = 500;
        shopItems[2, 4] = 650;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;






    }

    // this checks wheter the user has enough points too buy the items, if enough it subtracs the amount of their points and gives them the correct item and amount. 
    // This code works in combination with ButtonShopInfo. 

    public void Buy()
    {
        
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (PointManager.Points >= shopItems[2, ButtonRef.GetComponent<ButtonShopInfo>().ItemID]) 
        {
            PointManager.Points -= shopItems[2, ButtonRef.GetComponent<ButtonShopInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ButtonShopInfo>().ItemID]++;
            ButtonRef.GetComponent<ButtonShopInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonShopInfo>().ItemID].ToString();

            audio.Play();

        }
        else
        {
            Animes.Play("TextPopUp");
        }

        PointManager.UIRenderPoints();


    }

}
