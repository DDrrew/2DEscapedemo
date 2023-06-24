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
        showStr = "这幅画是2018年我18岁当天父亲送我的生日礼物。";
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
        showStr = "外面正在下雨,但是昨天的天气预报提示天晴。";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    public void Password_error_Tips()
    {
        panel.SetActive(true);
        showStr = "密码有误。";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    public void ClockTips()
    {
        panel.SetActive(true);
        showStr = "时钟显示现在是3月21日12：41，昨天刚过完我的23岁生日。";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

    public void Answer_error_Tips()
    {
        panel.SetActive(true);
        showStr = "回答有误。";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }
    
    public void DoorTips()
    {
        panel.SetActive(true);
        showStr = "门被锁上了。";
        stop_Cor1 = StartCoroutine(TypeText(showStr));
    }

}
