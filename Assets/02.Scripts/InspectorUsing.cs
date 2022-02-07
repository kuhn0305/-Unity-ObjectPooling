using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent (typeof(Rigidbody))]
//[AddComponentMenu("Custom/Component")]
//[ExecuteInEditMode]
public class InspectorUsing : MonoBehaviour
{
    [Header("Player Property")]
    //[SerializeField]
    private float healthPoint = 0;
    //[HideInInspector]
    public float mamaPoint = 0;


    public int attackPoint;
    public int attactSpeed;
    public int attackDelay;

    //[Space (10f)]
    public int moveSpeed;
    public int rotSpeed;

    [Space(15)]
    [Range(0.5f, 1.5f)]
    public float resizeAmount;

    [Space(15)]
    [Multiline(3)]
    public string multiLine;

    [Space(15)]
    [TextArea(3, 5)]
    [ContextMenuItem("Clear", "clearTextArea")]
    public string textArea;

    [Space(15)]
    [Tooltip("이것은 툴팁 입니다.")]
    public string toolTip;

    [System.Serializable]
    public class Serialize
    {
        public int a;
        public int b;
    }

    [Header("Serializable")]
    public Serialize serialize;

    [ContextMenu ("Randomize Stats")]
    public void RandomizeStats()
    {
        mamaPoint = Random.Range(0, 100);
    }

    public void clearTextArea()
    {
        textArea = "";
    }

    private void Update()
    {
        transform.localScale = new Vector3(resizeAmount, resizeAmount, resizeAmount);
    }
}
