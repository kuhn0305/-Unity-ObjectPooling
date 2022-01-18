using UnityEngine;
using System; // �� using ���ù� 

class ButtonEvent
{
    public event EventHandler Click; // �� �̺�Ʈ ���� 

    public void MouseButtonDown()
    {
        if (this.Click != null)
        {
            Click(this, EventArgs.Empty); // �̺�Ʈ �ڵ鷯���� ȣ�� 
        }
    }
}

public class EventExample : MonoBehaviour
{
    void Start()
    {
        ButtonEvent buttonEvent = new ButtonEvent();
        buttonEvent.Click += new EventHandler(ButtonClick);  // �� �̺�Ʈ ����    
        buttonEvent.Click += new EventHandler(ButtonClick2);

        buttonEvent.MouseButtonDown(); // ��� : ��ư Ŭ�� 
        buttonEvent.MouseButtonDown(); // ��� : ��ư Ŭ�� 
        buttonEvent.MouseButtonDown(); // ��� : ��ư Ŭ�� 
    }

    void ButtonClick(object sender, EventArgs e)  // �� ���� �޼��� : �̺�Ʈ �߻� 
    {
        Debug.Log("��ư Ŭ��");
    }

    void ButtonClick2(object sender, EventArgs e)  // �� ���� �޼��� : �̺�Ʈ �߻� 
    {
        //GameObject gameObject = Instantiate(prefab);
    }
}