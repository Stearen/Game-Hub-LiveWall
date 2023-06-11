using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Image PlaceHolder;
    public Sprite NewSprite;
    public Sprite YellowBox;
    public Sprite YellowBoxT;
    public bool BoxTrue;
    public bool DeleteItem;
    public GameObject SpriteStay;
    public GameObject BuildWorld;
    public GameObject StayActive;
    public GameObject ShopManager;
    public GameObject BuilderShop;
    public int ItemID;
    public RemoveItem removeItem;

    public GameObject OverworldImage;
    public Image TryoutImage;

    public ImageDisplay imageDisplay;

    public IDManager IDmanager;

    public AudioSource place;
    public AudioSource remove;




    public void Start()
    {
        BoxTrue = false;
        DeleteItem = false;

    }

    // this checks if a image CAN be placed on top of another image which should not be possible. 

    public void Update()
    {

        if (YellowBox.texture == YellowBoxT.texture)
        {
            BoxTrue = true;
        }
        else
        {
            BoxTrue = false;
        } 
            
        
    }

    // when a item is deleted a bool goes on, so that the script knows it shouldn't place but delete. This bool changes too true when the delete button is pressed. 
    // when a item is chosen to be deleted, it checks which ID this button has and changes the image back too the yellow place image and based in the ID gives the user the correct item back. 
    // lastly, it changes the ID back too 0, which makes it if the user tries to delete something which isn't even there the user doesn't get any free items. 
    public void DeleteObject()
    {

        if (removeItem.TrashItem == true)
        {
            remove.Play();
            ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID] += 1;
            ItemID = 0;
            PlaceHolder.sprite = YellowBoxT;
            YellowBox = YellowBoxT;
            OverworldImage.SetActive(false);
            removeItem.TrashItem = false;
            BuilderShop.SetActive(true);
            BuildWorld.SetActive(false); 



        }
    }


    // The Class NewImage first checks which ID and picture should be placed on that spot, this information they get from the IDManager. 
    // After, the code changes the correct image to the new image and makes it so the user can see it even if all the other images are inactive. 
    // These are images which are connected too each button, the images are called the Image Holders. 
    // Lastly, it resets the IDManager so it can't make any mistakes when deleting items or something else. 

    // this all can also only happen when the button has the correct YellowBox sprite because of a Booliën. 

    public void NewImage()
    {
        if (BoxTrue == true)
        {
            place.Play();

            NewSprite = IDmanager.NewerSprite;
            ItemID = IDmanager.Number;


            PlaceHolder.sprite = NewSprite;

            OverworldImage.SetActive(true);


            OverworldImage.GetComponent<ImageDisplay>().ShownImageSprite = NewSprite;

            SpriteStay.SetActive(true);
            BuildWorld.SetActive(false);

            YellowBox = NewSprite;

            TryoutImage = PlaceHolder;
            IDmanager.Number = 0;
           



        }







    }


}
