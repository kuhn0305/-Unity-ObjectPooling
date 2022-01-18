using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField]
    private string color;
    [SerializeField]
    private int index;

    public string Color
    {
        get { return this.color; }
    }

    public int Index 
    {
        get { return this.index; }
    }
}
