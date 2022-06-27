using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //platforms
    public Vector3 spawnPosition;
    public GameObject platformPrefab;
    public Transform playerTransform;
    public GameObject[] randomPlatforms;
    //coins
    public GameObject Coins;
    public Vector3 CoinSpawnPos;
    //enemy
    public GameObject Enemy;
    public Vector3 EnemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++) 
        {
            createPlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y > spawnPosition.y - 15)
            if (playerTransform.position.y>10)

            {
                randomPlatform();
            }
            else
            {
                createPlatform();
            }
        if (playerTransform.position.y>CoinSpawnPos.y -15)
        {
            createCoins();
        }
        if (playerTransform.position.y>EnemySpawn.y-15)
        {
            if (playerTransform.position.y>10)
            {
                createEnemy();
            }
        }
    }
    void createPlatform()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(0.5f, 2);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
    void randomPlatform()
    {
        int choose = Random.Range(0, randomPlatforms.Length);

        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(1.5f, 3);
        spawnPosition.y += randy;
        spawnPosition.x = randx;
        Instantiate(randomPlatforms[choose], spawnPosition, Quaternion.identity);

    }
    void createCoins()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(3f, 7);
        CoinSpawnPos.y += randy;
        CoinSpawnPos.x = randx;
        Instantiate(Coins, CoinSpawnPos, Quaternion.identity);

        
    } void createEnemy()
    {
        float randx = Random.Range(-3.5f, 3.5f);
        float randy = Random.Range(15f,20 );
        EnemySpawn.y += randy;
        EnemySpawn.x = randx;
        Instantiate(Enemy, EnemySpawn, Quaternion.identity);
    }
} 
