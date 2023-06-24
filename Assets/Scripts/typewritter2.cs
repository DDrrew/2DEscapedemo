using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typewritter2 : MonoBehaviour
{
    string str;
    Text tex;
    int i = 0;
    int index = 0;
    string str1 = "";
    bool ison = true;

    //public static GameObject txt;
    void Start()
    {
        tex = GetComponent<Text>();
        str = tex.text;
        tex.text = "";
        i = 70;

        
        //txt = GameObject.Find("text2");
        //txt.SetActive(false); //±£³ÖtxtµÄÒþ²Ø×´Ì¬
    }

    // Update is called once per frame

    public void Func()
    {
        textName();
    }

    public void textName()
    {
        if (ison)
        {
            i -= 1;
            if (i <= 0)
            {
                if (index >= str.Length)
                {
                    ison = false;
                    return;
                }
                str1 = str1 + str[index].ToString();
                tex.text = str1;
                index += 1;
                i = 60;
            }
        }
    }


    void Update()
    {
        Invoke("Func", 11);  //ÑÓ³Ù11sÖ´ÐÐFunc
    }
}
