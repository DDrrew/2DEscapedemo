using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxController : MonoBehaviour
{
    public bool isOpen=false;
    public GameObject KeyBorad;
    public InputField inputField;
    public UIController uIController;
    public GameObject box1;
    public GameObject box2;
    public bool isDoorOpen=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showKeyborad()
    {
        if (!isOpen)
        {
            KeyBorad.SetActive(true);
            isOpen = true;
        }
        else
        {
            KeyBorad.SetActive(false);
            isOpen = false;
        }
    }

    public void button_1()
    {
        inputField.text += "1";
    }

    public void button_2()
    {
        inputField.text += "2";
    }

    public void button_3()
    {
        inputField.text += "3";
    }

    public void button_4()
    {
        inputField.text += "4";
    }

    public void button_5()
    {
        inputField.text += "5";
    }

    public void button_6()
    {
        inputField.text += "6";
    }

    public void button_7()
    {
        inputField.text += "7";
    }

    public void button_8()
    {
        inputField.text += "8";
    }

    public void button_9()
    {
        inputField.text += "9";
    }

    public void button_0()
    {
        inputField.text += "0";
    }

    public void button_Del()
    {

    }

    public void button_enter()
    {

    }

    public void Check_password(string value)
    {
        if (value.Equals("123456"))
        {
            box1.SetActive(false);
            box2.SetActive(true);
        }
        else
        {
            uIController.Password_error_Tips();
            inputField.text = "";
        }
    }

    public void CheckDoorOpen()
    {
        if (isDoorOpen)
        {

        }
        else
        {
            uIController.DoorTips();
        }
    }

}
