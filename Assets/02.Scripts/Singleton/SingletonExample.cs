using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    private static SingletonExample instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        else        
            instance = this;

        // ��� ������ ����
        DontDestroyOnLoad(this.gameObject);
    }

    public static SingletonExample Instance
    {
        get { return instance; }
    }

    public static SingletonExample GetInstance()
    {
        if (instance == null)
        {
            Debug.LogError("SingletonExample �ν��Ͻ��� �������� �ʽ��ϴ�.");
            return null;
        }

        return instance;
    }

    public void Method1()
    {

    }
}
