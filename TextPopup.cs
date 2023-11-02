using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextPopup : MonoBehaviour
{
    public bool isMessage;
    public GameObject Message_btn;
    public Text Message_text;

    void ShowMessage(string message)
    {
        Message_btn.SetActive(true);
        Message_text.text = message;
    }
    void HideMessage()
    {
        Message_btn.SetActive(false);
        Message_text.text = "";
    }

    public IEnumerator StartAction(float time, string message)
    {
        isMessage = true;
        ShowMessage(message);
        yield return new WaitForSeconds(time);
        HideMessage();
        isMessage = false;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
