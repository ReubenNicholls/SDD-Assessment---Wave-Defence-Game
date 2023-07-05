using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMelee : MonoBehaviour
{
    public StartGame StartGame;
    public GameObject Player;
    public GameObject Fist;
    // Start is called before the first frame update
    void Start()
    {
         
    }
    // Update is called once per frame
    void Update()
    {
        if (StartGame.classMelee == 1)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                FistAttack();
            }
        }
        else if (StartGame.classMelee == 2)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                SwordAttack();
            }
        }
        else if (StartGame.classMelee == 3)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                SpearAttack();
            }
        }
    }
    public void FistAttack()
    {
        
        Instantiate(Fist);
        
    }
    public void SwordAttack()
    {

    }
    public void SpearAttack()
    {

    }
}
