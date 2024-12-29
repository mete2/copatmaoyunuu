using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopTorbasiSpawner2 : MonoBehaviour
{
    //-23.5 , 175
    private Vector3 spawnPoints;
    private float spawnCooldown;
    [SerializeField] private GameObject[] sahnedekiCopTorbalari;
    [SerializeField] private int sahnedekiAzamiCopTorbasiSayisi = 200;

    [SerializeField] private GameObject copTorbasi; // Instantiate için.
    [SerializeField] private LayerMask unSpawnableLayer; // Çakýþma kontrolü için layer
    private void Start()
    {
        StartCoroutine("Spawner");
        spawnCooldown = 5f;
    }
    private void Update()
    {
        sahnedekiCopTorbalari = GameObject.FindGameObjectsWithTag("CopTorbasi");
        if (spawnCooldown < 0)
        {
            spawnCooldown = 2f;
        }
        else
        {
            spawnCooldown -= Time.deltaTime;
        }

        if (spawnCooldown < 0.2f && sahnedekiCopTorbalari.Length < sahnedekiAzamiCopTorbasiSayisi)
        {
            Spawner();
            spawnCooldown = 2f;
        }
        
    }

    public void Spawner()
    {
        // Rastgele bir pozisyon oluþtur
        spawnPoints = new Vector3(Random.Range(131, 260), 12.1f, 0);

        // Çakýþma kontrolü yap (örneðin, yarýçap 1 birimlik bir alaný kontrol et)
        if (!Physics.CheckSphere(spawnPoints, 0.1f, unSpawnableLayer))
        {
            // Çöp torbasýný oluþtur
            Instantiate(copTorbasi, spawnPoints, Quaternion.identity);
        }
        else
        {
            print("DUVARIN ÝÇÝNDE");
            print(spawnPoints);
        }
    }
}
