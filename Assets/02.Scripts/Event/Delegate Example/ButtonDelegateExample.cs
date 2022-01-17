using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDelegateExample : MonoBehaviour
{
    public Button someButton;

    void OnEnable()
    {
        //Register Button Events
        someButton.onClick.AddListener(() => buttonCallBack("Hello World!", 88));
        someButton.onClick.AddListener(delegate { buttonCallBack("Hi", 5733); });
    }

    private void buttonCallBack(string myStringValue, int myIntValue)
    {
        Debug.Log("Button Clicked. Received string: " + myStringValue + " with int: " + myIntValue);
    }

    void OnDisable()
    {
        //Un-Register Button Events
        someButton.onClick.RemoveAllListeners();
    }
}
