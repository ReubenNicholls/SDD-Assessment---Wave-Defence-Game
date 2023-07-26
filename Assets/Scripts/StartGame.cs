using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public float playerClass = 0;
    public GameObject StartMenu;
    public bool startGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            playerClass = 1;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            playerClass = 2;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha3)) 
        {
            playerClass = 3;
            startGame = true;
        }
        if (startGame)
        {
            StartMenu.SetActive(false);
        }
        

    }
}
