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

    [SerializeField] private GameObject copTorbasi; // Instantiate i�in.
    [SerializeField] private LayerMask unSpawnableLayer; // �ak��ma kontrol� i�in layer
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
        // Rastgele bir pozisyon olu�tur
        spawnPoints = new Vector3(Random.Range(131, 260), 12.1f, 0);

        // �ak��ma kontrol� yap (�rne�in, yar��ap 1 birimlik bir alan� kontrol et)
        if (!Physics.CheckSphere(spawnPoints, 0.1f, unSpawnableLayer))
        {
            // ��p torbas�n� olu�tur
            Instantiate(copTorbasi, spawnPoints, Quaternion.identity);
        }
        else
        {
            print("DUVARIN ���NDE");
            print(spawnPoints);
        }
    }
}
