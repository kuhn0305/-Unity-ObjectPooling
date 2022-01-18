using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class ButtonDelegateExample : MonoBehaviour
{
    public Button someButton;

    private ColorPicker colorPicker;

    public UnityEvent awakeEvent;

    private void Awake()
    {
        awakeEvent?.Invoke();

        colorPicker = GetComponent<ColorPicker>();
    }

    void OnEnable()
    {
        //Register Button Events
        someButton.onClick.AddListener(() => buttonCallBack(colorPicker.Color, colorPicker.Index));
        someButton.onClick.AddListener(delegate 
        { 
            buttonCallBack("Hi", 5733); 
        });
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
