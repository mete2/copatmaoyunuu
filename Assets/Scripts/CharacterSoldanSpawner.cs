using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterSoldanSpawner : MonoBehaviour
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
    //-55 , -126
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
        spawnPoints = new Vector3(Random.Range(-55,-126), 0.5f, 3.5f);
        int karakter = Random.Range(0, 6);
        Instantiate(characters[karakter], spawnPoints, Quaternion.Euler(0,90,0));
    }
}
