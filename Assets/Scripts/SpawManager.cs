using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int ballIndex;
    private float spawnRangeX = 10.0f;
    private float spawnPosY = 20.0f;

    [SerializeField,Range(2,5)]
    private float startDelay = 2.0f;

    [SerializeField, Range(0.1f, 3)]
    private float spawnInterval = 0.1f;

    private float counter = 0.0f;
    private float nextTimeWait = 2.0f;

    //Una lista
    //public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosY = transform.position.y;

        //invoca un método repetidamente después de un delay inicial y cada cierto tiempo
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter>= nextTimeWait)
		{
            Debug.LogFormat("Hemos esperado {0}s", nextTimeWait);
            SpawnRandomBall();
            counter = 0;
            nextTimeWait = Random.Range(1.0f,5.0f);
        }
        
    }

    private void SpawnRandomBall()
	{
        //posicion donde aparece el enemigo
        float xRand = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(xRand, spawnPosY, 0);

        ballIndex = Random.Range(0, enemies.Length);

        Instantiate(enemies[ballIndex], spawnPos,
                    enemies[ballIndex].transform.rotation);
    }
}
