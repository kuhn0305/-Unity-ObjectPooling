using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonymousExample : MonoBehaviour
{
    delegate int MyDelegate(int a, int b);

    private void Start()
    {
        LambdaExpressionExample();
    }

    void AnonymousTypeExample()
    {
        var t = new { name = "Coderzero", age = 47 };
        Debug.LogFormat($"{t.name} {t.age}");
    }

    void AnonymousMethodExample()
    {
        MyDelegate sum;
        sum = delegate (int a, int b)
        {
            return a + b;
        };
    }

    delegate int Calculate(int a, int b);

    void LambdaExpressionExample()
    {
        Calculate calculate = (a, b) => a + b;
        Debug.LogFormat($"{1} + {2} = {calculate(1, 2)}");
    }

    void FuncActionExample()
    {
        Func<int> func1 = () => 1;
        Debug.LogFormat($"{func1()}"); // 출력 : 1  

        Func<int, int> func2 = (a) => a * 2;
        Debug.LogFormat($"{func2(3)}"); // 출력 : 6  

        Action action1 = () => Debug.Log("Action"); // 출력 : Action  
        action1();

        Action<int, int> action2 = (a, b) => Debug.LogFormat($"{a} {b}"); // 출력 : 1 2  
        action2(1, 2);
    }
}
