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

        // 모든 씬에서 유지
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
            Debug.LogError("SingletonExample 인스턴스가 존재하지 않습니다.");
            return null;
        }

        return instance;
    }

    public void Method1()
    {

    }
}
