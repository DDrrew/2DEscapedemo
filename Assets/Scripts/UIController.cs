using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject panel;
    public Text showText;
    string showStr;
    public Coroutine stop_Cor1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void paintingTips()
    {
        panel.SetActive(true);
        showStr = "�������2018����18�굱�츸�����ҵ��������";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    private IEnumerator TypeText(string showStr)
    {
        foreach(var item in showStr.ToCharArray())
        {
            showText.text += item;
            yield return new WaitForSeconds(0.1f);
        }
        StopCoroutine(stop_Cor1);
    }

    public void nextButton()
    {
        panel.SetActive(false);
        showText.text = "";
    }

    public void windowsTips()
    {
        panel.SetActive(true);
        showStr = "������������,�������������Ԥ����ʾ���硣";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    public void Password_error_Tips()
    {
        panel.SetActive(true);
        showStr = "��������";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    public void ClockTips()
    {
        panel.SetActive(true);
        showStr = "ʱ����ʾ������3��21��12��41������չ����ҵ�23�����ա�";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    public void Answer_error_Tips()
    {
        panel.SetActive(true);
        showStr = "�ش�����";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }
    
    public void DoorTips()
    {
        panel.SetActive(true);
        showStr = "�ű������ˡ�";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

}
