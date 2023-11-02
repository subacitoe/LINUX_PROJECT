using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    // Start is called before the first frame update
    public PC[] PCSystem;
    public _SWITCH[] SwitchSystem;
    //public _ROUTER[] RouterSystem;

    void Start()
    {
        //Check System After Boot
        foreach (var item in PCSystem)
        {
            Debug.Log(item.IP);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
