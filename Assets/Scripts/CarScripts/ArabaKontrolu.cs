using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.Experimental;

public class ArabaKontrolu : MonoBehaviour
{
    [SerializeField] GazaBas gazaBas;
    public Rigidbody rb;
    [SerializeField] float arabanýnKutlesi;
    Vector3 spawnPosition;
    private void Awake()
    {
        FallingCollider.OnCarRespawn += Respawn;
        rb = GetComponent<Rigidbody>();
        switch (PlayerPrefs.GetInt("SpawnPoint"))
        {
            case 0: spawnPosition = new Vector3(-8, 0.5f, 0.5f); 
                break;
            case 1: spawnPosition = new Vector3(662, -27.11f, 0.5f); 
                break;
            case 2: spawnPosition = new Vector3(1320, -16.91f, 0.5f); 
                break;
        }
        rb.position = spawnPosition;
        transform.position = spawnPosition;
    }

    public void Respawn()
    {
        print("Respawn oldu.");
        transform.position = new Vector3(-8, 0.5f, 0.5f);
        transform.eulerAngles = new Vector3(0, 90, 0);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        Physics.SyncTransforms();
    }

    void FixedUpdate()
    {
        float speed = (CarSkillLevelManager.speedLevel + 1) / 35;
        rb.AddForce(-transform.up * arabanýnKutlesi, ForceMode.Force); // yere sabit kalsýn diye
        rb.velocity = new Vector2(gazaBas.speed * (0.05f + speed), rb.velocity.y);
    }
}
