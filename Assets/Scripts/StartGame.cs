using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public float classMelee = 0;
    public float classRange = 0;
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
            classMelee = 1;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            classMelee = 2;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha3)) 
        { 
            classMelee = 3;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            classRange = 1;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha5))
        {
            classRange = 2;
            startGame = true;
        }
        else if (Input.GetKey(KeyCode.Alpha6))
        {
            classRange = 3;
            startGame = true;
        }
        
        if (startGame == true)
        {
            StartMenu.SetActive(false);
        }
    }
}
