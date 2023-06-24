using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public Texture2D cursor1;
    public Texture2D cursor2;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Check();
    }

    public void Check()
    {
        RaycastHit2D[] hitObjs = Physics2D.RaycastAll(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hitObjs.Length == 0)
        {
            Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
        }
        foreach (var hit in hitObjs)
        {
            if (hit.collider.tag == "property")
            {
                Cursor.SetCursor(cursor2, Vector2.zero, CursorMode.Auto);
            }
        }
    }
}
