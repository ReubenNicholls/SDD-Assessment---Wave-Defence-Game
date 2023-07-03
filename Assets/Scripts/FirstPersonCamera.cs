using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform player;
    public float mouseSens = 2f;
    float cameraVertRotation = 0f;
    public StartGame StartGame;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (StartGame.startGame == true)
        {
            float inputX = Input.GetAxis("Mouse X") * mouseSens;
            float inputY = Input.GetAxis("Mouse Y") * mouseSens;

            cameraVertRotation -= inputY;
            cameraVertRotation = Mathf.Clamp(cameraVertRotation, -90f, 90f);
            transform.localEulerAngles = Vector3.right * cameraVertRotation;
            player.Rotate(Vector3.up * inputX);
        }
        
    }
}
