using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveItem : MonoBehaviour
{

    
    public GameObject BuilderWorld;

    public bool TrashItem;

    // Start is called before the first frame update
    void Start()
    {
        TrashItem = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Delete()
    {

        TrashItem = true;
        BuilderWorld.SetActive(true);

    }


}
