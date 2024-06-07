using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
     public GameObject[] fruits;
    [SerializeField] private GameObject bomb;
    [SerializeField] private float spawnSpeed = 2;

    private void Start()
    {
        StartCoroutine(SpawnerFruits());
    }

    private IEnumerator SpawnerFruits()
    {
        while(true)
        {
            Vector3 randomPosition = new(Random.Range(-8, 8), 6);
            var chance = Random.Range(0, 50);
            var randomFruits = Random.Range(0, fruits.Length);


            if (chance <= 35)
            {
                Instantiate(fruits[randomFruits], randomPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnSpeed);
                spawnSpeed = spawnSpeed - 0.05f;

            }

            if (chance >= 35)
            {
                Instantiate(bomb, randomPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnSpeed);
                spawnSpeed = spawnSpeed - 0.05f;


            }

            if (spawnSpeed <= 1) spawnSpeed = 1;
        }
       

    }
}
