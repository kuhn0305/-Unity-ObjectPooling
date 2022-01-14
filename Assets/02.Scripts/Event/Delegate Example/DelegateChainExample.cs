using UnityEngine;

public class DelegateChainExample : MonoBehaviour
{
    delegate void CalculateDelegate(int a, int b);

    void Start()
    {
        CalculateDelegate calculateDelegate = Add;

        calculateDelegate += Subtract;
        calculateDelegate(3, 2); // Ãâ·Â : 5  
                                 //       1       
    }

    void Add(int a, int b)
    {
        Debug.Log(a + b);
    }

    void Subtract(int a, int b)
    {
        Debug.Log(a - b);
    }
}