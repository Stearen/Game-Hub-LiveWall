using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageDisplay : MonoBehaviour
{
    public Image ShownImage;
    public Sprite ShownImageSprite;
   

    // Start is called before the first frame update
    private void Update()
    {
        ShownImage.sprite = ShownImageSprite;
    }

    

}
