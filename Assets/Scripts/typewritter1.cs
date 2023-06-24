using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typewritter1 : MonoBehaviour
{
    // Start is called before the first frame update

    string str;
    Text tex;
    int i = 0;
    int index = 0;
    string str1 = "";
    bool ison = true;


    void Start()
    {
        tex = GetComponent<Text>();
        str = tex.text;
        tex.text = "";
        i = 70;

    }

    // Update is called once per frame
    public void control()
    {
        
    }
    void Update()
    {
        if (ison)
        {
            i -= 1;
            if(i<=0)
            {
                if (index >= str.Length)
                {
                    ison = false;
                    GameObject.Find("text2").GetComponent<typewritter2>();
                    return;
                }
                str1 = str1 + str[index].ToString();
                tex.text = str1;
                index += 1;
                i = 60;
            }
        }
    }
}
