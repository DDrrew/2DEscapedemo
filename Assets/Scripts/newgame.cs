using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void new_game()
    {
        SceneManager.LoadScene("newgame");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
