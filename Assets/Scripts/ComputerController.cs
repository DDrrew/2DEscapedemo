using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerController : MonoBehaviour
{
    public GameObject shutComputer;
    public GameObject loginBg;
    public GameObject startComputer;
    public UIController uIController;
    public bool isRunning=false;
    public InputField inputField; 
    public int Click_times = 0;
    public GameObject TxtText;
    public GameObject WindowsOut;
    public GameObject Cover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check_password(string value)
    {
        if (value.Equals("20000320"))
        {
            loginBg.SetActive(false);
            startComputer.SetActive(true);
        }
        else
        {
            uIController.Password_error_Tips();
            inputField.text = "";
        }
    }

    public void OpenComputer()
    {
        if (!isRunning)
        {
            shutComputer.SetActive(false);
            loginBg.SetActive(true);
            isRunning = true;
        }
        else
        {
            shutComputer.SetActive(true);
            loginBg.SetActive(false);
            startComputer.SetActive(false);
            isRunning = false;
            inputField.text = "";
        }
    }

    public void TxtDoubleClick()
    {
        Click_times++;
        if (Click_times >= 2)
        {
            Click_times = 0;
        }
        TxtText.SetActive(true);
    }

    public void CoverClick()
    {
        WindowsOut.SetActive(true);
    }

    public void CheckAnswer(string value)
    {
        if (value == "0")
        {
            uIController.Answer_error_Tips();
            inputField.text = "";
        } 
        WindowsOut.SetActive(false);
        Cover.SetActive(false);
          
    }

}
