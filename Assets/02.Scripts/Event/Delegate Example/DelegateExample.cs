using UnityEngine;

public class DelegateExample : MonoBehaviour
{

    delegate int CalculateDelegate(int a, int b);

    void Start()
    {
        CalculateDelegate Plus = new CalculateDelegate(Add); 
        CalculateDelegate Minus = Subtract;

        DebugLog(1, 2, Plus);
        DebugLog(4, 3, Minus);
    }

    void DebugLog(int a, int b, CalculateDelegate calculateDelegate)
    {
        Debug.Log(calculateDelegate(a, b));
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    int Subtract(int a, int b)
    {
        return a - b;
    }
}