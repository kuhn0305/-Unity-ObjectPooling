using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

    private static ObjectPool instance;

    [SerializeField]
    private GameObject poolingObjectPrefab; 
    [SerializeField]
    private int poolCount = 10;

    Queue<Bullet> poolingObjectQueue = new Queue<Bullet>();

    public static ObjectPool Instance
    {
        get { return instance; }
    }

    private void Awake() 
    {
        if(instance != null)
        {
            Destroy(instance);
        }
        else
            instance = this;

        // 모든 씬에서 유지
        DontDestroyOnLoad(this.gameObject);
        Initialize(poolCount); 
    } 

    private void Initialize(int initCount) 
    {
        for (int i = 0; i < initCount; i++) 
        { 
            poolingObjectQueue.Enqueue(CreateNewObject());
        } 
    }

    private Bullet CreateNewObject() 
    {
        var newObj = Instantiate(poolingObjectPrefab).GetComponent<Bullet>();
        newObj.gameObject.SetActive(false); newObj.transform.SetParent(transform);
        return newObj;
    } 

    public static Bullet GetObject()
    {
        if (instance.poolingObjectQueue.Count > 0)
        {
            var obj = instance.poolingObjectQueue.Dequeue();
            obj.transform.SetParent(null); 
            obj.gameObject.SetActive(true); 
            return obj;
        } 
        else
        { 
            var newObj = instance.CreateNewObject();
            newObj.gameObject.SetActive(true);
            newObj.transform.SetParent(null);
            return newObj;
        }
    } 
    public static void ReturnObject(Bullet obj)
    {
        obj.gameObject.SetActive(false); 
        obj.transform.SetParent(instance.transform);
        instance.poolingObjectQueue.Enqueue(obj);
    } 
}
