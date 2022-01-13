using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
    IEnumerator timeIEnumerator;
    IEnumerator simpleIEnumerator;
    IEnumerator loopingIEnumerator;

    private bool questSuccess = false;

    [SerializeField]
    private List<string> infoStringList;

    private void Awake()
    {
        timeIEnumerator = TimeCoroutine();
        loopingIEnumerator = LoopingCoroutine();
    }


    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0.5f;

        StartCoroutine(WaitingCoroutine());

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Start Coroutine");
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StopCoroutine(loopingIEnumerator);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(loopingIEnumerator);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            questSuccess = true;
        }
    }


    IEnumerator SimpleCoroutine()
    {
        Debug.Log("Coroutine Called!");

        yield return new WaitForEndOfFrame();
    }

    IEnumerator TimeCoroutine()
    {
        yield return new WaitForSeconds(4f);
        Debug.Log("Wait For Seconds");


        // Time Scale에 영향을 받지 않음
        yield return new WaitForSecondsRealtime(4f);
        Debug.Log("Wait For Seconds Realtime");
    }

    IEnumerator LoopingCoroutine()
    {
        float value = 0;

        while (true)
        {
            value += Time.deltaTime;

            Debug.Log($"Looping Time :: {value}");

            yield return null;
            //yield break;
        }
    }


    // [duration] 동안 [start]에서 [destination]까지 보간할 때 사용한다.
    IEnumerator LerpCoroutine(float start, float destination, float duration)
    {
        float timer = 0f;
        float value = 0f;

        YieldInstruction waitFrame = new WaitForEndOfFrame();

        while (timer <= duration)
        {
            value = timer / duration;

            Debug.Log(Mathf.Lerp(start, destination, value));

            yield return waitFrame;
            timer += Time.deltaTime;
        }

        Debug.Log(destination);
    }

    IEnumerator WaitingCoroutine()
    {
        foreach(string infoText in infoStringList)
        {
            yield return StartCoroutine(SequenceCoroutine(infoText));
        }
    }


    IEnumerator SequenceCoroutine(string infoText)
    {
        Debug.Log(infoText);

        yield return new WaitUntil(() => questSuccess);

        questSuccess = false;
    }
}
