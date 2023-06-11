using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlacementController : MonoBehaviour
{
    [SerializeField] private GameObject placeableObjectPrefab;

    private GameObject currentPlaceableObject;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ItemPlacement()
    {
        if (currentPlaceableObject == null)
        {
            currentPlaceableObject = Instantiate(placeableObjectPrefab);
        }
        else
        {
            Destroy(currentPlaceableObject);
        }

    }


}
