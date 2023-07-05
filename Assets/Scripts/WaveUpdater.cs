using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveUpdater : MonoBehaviour
{
    public float enemyCount = 0;
    public float waveCount = 1;
    public bool isWaveOver;
    public EnemyStats EnemyStats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* if (EnemyStats.enemiesKilled <= 0)
         * isWaveOver = true
         * waveCount++
         * isWaveOver = false
         */
    }
}
