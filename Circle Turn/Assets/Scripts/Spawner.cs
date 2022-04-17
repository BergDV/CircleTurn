using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject Bonus;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnBonus());


    }
    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos1 = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(Enemy, pos1, Quaternion.identity);
        Repeat1();
    }
    IEnumerator SpawnBonus()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos2 = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(Bonus, pos2, Quaternion.identity);




        Repeat2();
    }


    void Repeat1()
    {
        StartCoroutine(SpawnEnemy());

    }
    void Repeat2()
    {
        StartCoroutine(SpawnBonus());


    }
}






