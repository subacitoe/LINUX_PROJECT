using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandBlock : MonoBehaviour
{
    [Header("Inventory")]
    public GameObject Inventory_obj;
    public void Inventory()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            Inventory_obj.SetActive(!Inventory_obj.activeSelf);
        }
    }
    public void CloseInventory()
    {
        if(Inventory_obj.activeSelf)
            Inventory_obj.SetActive(false);
    }
     public void OpenInventory()
    {
        if(!Inventory_obj.activeSelf)
            Inventory_obj.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inventory();
    }
}
