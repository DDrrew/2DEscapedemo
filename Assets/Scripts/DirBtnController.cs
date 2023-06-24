using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirBtnController : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject down;
    public Camera m_Camera;
    public Button LeftBtn;
    public Button RightBtn;
    public Button DownBtn;
    public GameObject open;
    public GameObject sys1;
    public GameObject sys2;
    public GameObject black;
    public GameObject box2;
    public GameObject keyborad;
    public Vector2 OriginalPos;
    public Vector2 BeforePos;

    // Start is called before the first frame update
    void Awake()
    {
        LeftBtn = left.GetComponentInChildren<Button>();
        RightBtn = right.GetComponentInChildren<Button>();
        DownBtn = down.GetComponentInChildren<Button>();
        LeftBtn.onClick.AddListener(OnLeftBtnClick);
        RightBtn.onClick.AddListener(OnRightBtnClick);
        DownBtn.onClick.AddListener(OnDownBtnClick);
    }

    // Update is called once per frame
    void Update()
    {
        OriginalPos = m_Camera.transform.position;
    }

    public void OnLeftBtnClick()
    {
        m_Camera.transform.position = OriginalPos - new Vector2(22, 0);
    }

    public void OnRightBtnClick()
    {
        m_Camera.transform.position = OriginalPos + new Vector2(22, 0);
    }

    public void OnDownBtnClick()
    {
        left.SetActive(true);
        right.SetActive(true);
        black.SetActive(true);
        down.SetActive(false);
        open.SetActive(false);
        sys1.SetActive(false);
        sys2.SetActive(false);
        box2.SetActive(false);
        keyborad.SetActive(false);
        m_Camera.transform.position = BeforePos;
    }

    public void MoveCompter()
    {
        left.SetActive(false);
        right.SetActive(false);
        down.SetActive(true);
        open.SetActive(true);
        BeforePos = OriginalPos;
        m_Camera.transform.position = OriginalPos + new Vector2(0, 12);
    }

    public void MoveBox()
    {
        left.SetActive(false);
        right.SetActive(false);
        down.SetActive(true);
        BeforePos = OriginalPos;
        m_Camera.transform.position = OriginalPos + new Vector2(0, 12);
    }

}
