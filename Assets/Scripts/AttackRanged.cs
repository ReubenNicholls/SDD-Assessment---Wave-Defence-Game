using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRanged : MonoBehaviour
{
    public StartGame StartGame;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StartGame.classRange == 1)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                BowAttack();
            }
        }
        else if (StartGame.classRange == 2)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                GunAttack();
            }
        }
        else if (StartGame.classRange == 3)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                MiscAttack();
            }
        }
    }
    public void BowAttack()
    {

    }
    public void GunAttack()
    {

    }
    public void MiscAttack()
    {

    }
}