using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    [SerializeField] private bool isInRange;
    [Header("Popup")]
    public TextPopup _textPopup;
    public string Says;

    // Start is called before the first frame update
    void Start()
    {
        _textPopup = GameObject.Find("PopupMessage").GetComponent<TextPopup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isInRange && !_textPopup.isMessage)
        {
            StartCoroutine(_textPopup.StartAction(3, Says));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered is the player (you might need to tag your player GameObject)
        if (other.CompareTag("Player"))
        {
           isInRange = true;
        //    Debug.Log(isInRange);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the object that entered is the player (you might need to tag your player GameObject)
        if (other.CompareTag("Player"))
        {
           isInRange = false;
        //    Debug.Log(isInRange);
        }
    }
}
