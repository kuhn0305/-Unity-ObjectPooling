using UnityEngine;
using System; // ① using 지시문 

class ButtonEvent
{
    public event EventHandler Click; // ② 이벤트 정의 

    public void MouseButtonDown()
    {
        if (this.Click != null)
        {
            Click(this, EventArgs.Empty); // 이벤트 핸들러들을 호출 
        }
    }
}

public class EventExample : MonoBehaviour
{
    void Start()
    {
        ButtonEvent buttonEvent = new ButtonEvent();
        buttonEvent.Click += new EventHandler(ButtonClick);  // ③ 이벤트 연결    

        buttonEvent.MouseButtonDown(); // 출력 : 버튼 클릭 
        buttonEvent.MouseButtonDown(); // 출력 : 버튼 클릭 
        buttonEvent.MouseButtonDown(); // 출력 : 버튼 클릭 
    }

    void ButtonClick(object sender, EventArgs e)  // ④ 실행 메서드 : 이벤트 발생 
    {
        Debug.Log("버튼 클릭");
    }
}