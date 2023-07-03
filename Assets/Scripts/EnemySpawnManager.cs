using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public float spawnInterval = 1.5f;
    public GameObject Enemy;
    public StartGame StartGame;
    public WaveUpdater WaveUpdater;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (!StartGame.startGame || !WaveUpdater.isWaveOver)
        {
            while(WaveUpdater.enemyCount < WaveUpdater.waveCount * 5)
            {
                Invoke("SpawnEnemy", spawnInterval);
                WaveUpdater.enemyCount++;
            }
        }
    }
    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(300, -300), -3, Random.Range(300, -300));
        Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
    }
}
