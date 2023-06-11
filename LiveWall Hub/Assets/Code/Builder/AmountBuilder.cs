using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class AmountBuilder : MonoBehaviour
{
    public TextMeshProUGUI Amount;
    public GameObject ShopManager;
    public int ItemID;
    public int Amounttext;
    public int minusItem = 1;
    public GameObject Item;
    public GameObject PlaceBlocks;
    public GameObject SendImageID;
    public Sprite SpriteImage;

    public ChangeImage changeImage;
    public ChangeImage changeImage2;
    public ChangeImage changeImage3;
    public ChangeImage changeImage4;
    public ChangeImage changeImage5;

    public IDManager IDmanager;




    private void Start()
    {


    }

    // this updates the amount of items the builder has whenever the user buys something from the shop. Works the same as in ButtonShopInfo. 
    void Update()
    {

        Amount.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
        Amounttext = int.Parse(Amount.text);

    }
 


    // dit bekijkt welk item de user wilt plaatsen en geeft het ID van dit item door aan de IDManager. 
    // De IDManager kan het juiste plaatje en ID dan aan de knop/plaats geven van waar de user het wilt plaatsen. 
    public void ItemChoice()
    {

        if (Amounttext >= 1)
        {
            Amounttext -= minusItem;
            ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID] -= minusItem;

            if (Item.activeInHierarchy == true)
            {
                Item.SetActive(false);
                PlaceBlocks.SetActive(true);

                IDmanager.Number = ItemID;
                IDmanager.NewerSprite = SpriteImage;
            }
        }
    }
}
