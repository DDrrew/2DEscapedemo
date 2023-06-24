using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingBtn : MonoBehaviour
{
    public GameObject settingCav;
    public bool SwitchFlag;
    private Button set_btn;
    // Start is called before the first frame update
    void Start()
    {
        set_btn = GetComponent<Button>();
        set_btn.onClick.AddListener(OnStartBtnClick);
        SwitchFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartBtnClick()
    {
        if (SwitchFlag)
        {
            settingCav.SetActive(true);
            SwitchFlag = false;
        }
        else
        {
            settingCav.SetActive(false);
            SwitchFlag = true;
        }
    }

}
