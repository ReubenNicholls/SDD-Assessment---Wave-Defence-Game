using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float enemyHitPoints = 20;
    public float enemyDamage = 5;
    public WaveUpdater WaveUpdater;
    // Start is called before the first frame update
    void Start()
    {
        //basehp * (wavecount * 1/4)
        //basedmg * (wavecount * 1/2)
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        /* when hit 
         * enemyhp - playerDamage (depending on class picked)
         * 
         * if enemyhp =< 0
         * {despawn enemy
         * enemieskilled++}
         */
        
    }
}
