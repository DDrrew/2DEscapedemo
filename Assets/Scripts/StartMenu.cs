using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public Button m_GameStart;
    public Button m_Save;
    public Button m_CheckStory;
    public Button m_Exit;

    // Start is called before the first frame update
    void Awake()
    {
        m_GameStart = GameObject.Find("newGame").GetComponentInChildren<Button>();
        m_GameStart.onClick.AddListener(OnStartClick);
        m_Save = GameObject.Find("reload").GetComponentInChildren<Button>();
        m_Save.onClick.AddListener(OnSaveClick);
        m_CheckStory = GameObject.Find("checkStory").GetComponentInChildren<Button>();
        m_CheckStory.onClick.AddListener(OnCheckClick);
        m_Exit = GameObject.Find("exit").GetComponentInChildren<Button>();
        m_Exit.onClick.AddListener(OnExitClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    public void OnSaveClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }

    public void OnCheckClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
    }

    public void OnExitClick()
    {
        Application.Quit();
    }

}
