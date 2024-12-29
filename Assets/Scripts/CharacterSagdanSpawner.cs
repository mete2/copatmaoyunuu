using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterSagdanSpawner : MonoBehaviour
{
    //-23.5 , 175
    private Vector3 spawnPoints;
    private float spawnCooldown;
    [SerializeField] private GameObject[] sahnedekiKarakterler;

    [SerializeField] private GameObject[] characters; // Instantiate için.
    private void Start()
    {
        Spawner();
        spawnCooldown = 5f;
    }
    private void Update()
    {
        sahnedekiKarakterler= GameObject.FindGameObjectsWithTag("Character");
        if (spawnCooldown < 0)
        {
            spawnCooldown = 10f;
        }
        else
        {
            spawnCooldown -= Time.deltaTime;
        }

        if (spawnCooldown < 0.2f && sahnedekiKarakterler.Length < 70)
        {
            Spawner();
            spawnCooldown = 10f;
        }

    }
    public void Spawner()
    {
        // Rastgele bir pozisyon oluþtur
        spawnPoints = new Vector3(Random.Range(1375, 1438), -16.25f, 3.5f);
        int karakter = Random.Range(0, 6);
        Instantiate(characters[karakter], spawnPoints, Quaternion.identity);
    }
}
