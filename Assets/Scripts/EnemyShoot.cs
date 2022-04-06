using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [Header("Shooting Rate")]
    [SerializeField]
    private float interval = 1.0f;

    private float timer = 0.0f;
    public GameObject Enem_BulletPrefab;
    public Transform BulletSpawn;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        timer += Time.deltaTime * 1;

        if (timer > interval)
        {
            Instantiate(Enem_BulletPrefab, transform.position, Quaternion.identity);
            timer = 0.0f;
        }
    }

    private void SpawnEnemyBullet()
    {
        GameObject EBullet = Instantiate(Enem_BulletPrefab, BulletSpawn.position, Quaternion.identity) as GameObject;
    }



    // Update is called once per frame

    /*
    IEnumerator BulletWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemyBullet();
        }
    }
    */
}
