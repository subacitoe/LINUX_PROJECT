using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEngine;
using UnityEngine.UI;

public class PC : MonoBehaviour
{

    [SerializeField] private string macAddress;
    
    [SerializeField] private string defaultGateway;
    [SerializeField] private string subnetMask;
    [SerializeField] private string name;


    [Header("IP")]
    [SerializeField] private string ip;
    [SerializeField] InputField ipField1;
    [SerializeField] InputField ipField2;
    [SerializeField] InputField ipField3;
    [SerializeField] InputField ipField4;


    [SerializeField] private GameObject PCSetting;
    //
    private void Start()
    {
        PCSetting.SetActive(false);
    }
    public string MAC
    {
        get
        {
            return macAddress; // Return the stored MAC address
        }
        set
        {
            macAddress = value; // Set the MAC address when a new value is assigned
        }
    }

    public string IP
    {
        get
        {
            return ip; // Return the stored MAC address
        }
        set
        {
            ip = value; // Set the MAC address when a new value is assigned
        }
    }

    public string NAME
    {
        get
        {
            return name; // Return the stored MAC address
        }
        set
        {
            name = value; // Set the MAC address when a new value is assigned
        }
    }
    public string DEFAULTGATEWAY
    {
        get
        {
            return defaultGateway; // Return the stored MAC address
        }
        set
        {
            defaultGateway = value; // Set the MAC address when a new value is assigned
        }
    }

    public string SUBNETMASK
    {
        get
        {
            return subnetMask; // Return the stored MAC address
        }
        set
        {
            subnetMask = value; // Set the MAC address when a new value is assigned
        }
    }
    public void ShowSetting()
    {
        if (PCSetting != null) { 
            PCSetting.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (PCSetting != null && collision.CompareTag("Player"))
        {
            this.PCSetting.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        this.ip = ipField1.text +"."+ipField2.text + "."+ipField3.text +"." + ipField4.text;
    }


}
