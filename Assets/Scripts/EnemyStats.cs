using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float enemyHitPoints = 20;
    public float enemyDamage = 5;
    public float enemiesKilled = 0;
    public GameObject Enemy;
    public WaveUpdater WaveUpdater;
    public PlayerStats PlayerStats;
    // Start is called before the first frame update
    void Start()
    {
        enemyHitPoints *= WaveUpdater.waveCount*(1/4);
        enemyDamage *= WaveUpdater.waveCount*(1/2);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHitPoints <= 0)
        {
            Destroy(Enemy);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MeleeFist"))
        {
            enemyHitPoints -= PlayerStats.playerDamage;
        }

    }
}
