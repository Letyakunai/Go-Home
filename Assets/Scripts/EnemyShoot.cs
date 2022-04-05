using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject Enem_BulletPrefab;
    public Transform BulletSpawn;
    public float respawnTime = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BulletWave());
    }

    private void SpawnEnemyBullet()
    {
        GameObject EBullet = Instantiate(Enem_BulletPrefab, BulletSpawn.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    IEnumerator BulletWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemyBullet();
        }
    }
}
