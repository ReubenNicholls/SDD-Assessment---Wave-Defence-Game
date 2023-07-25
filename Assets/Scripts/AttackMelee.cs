using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
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
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    FistAttack();
                }
            }
            else if (StartGame.classMelee == 2)
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    SwordAttack();
                }
            }
            else if (StartGame.classMelee == 3)
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    SpearAttack();
                }
            }
        
     }
     public void FistAttack()
     {
        Vector3 playerPos = Player.transform.position;
        Vector3 playerDirection = Player.transform.forward;
        float spawnDistance = 15;
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        Instantiate(Fist, spawnPos, Player.transform.rotation);

     }
     public void SwordAttack()
     {

     }
     public void SpearAttack()
     {

     }
        
    
}
