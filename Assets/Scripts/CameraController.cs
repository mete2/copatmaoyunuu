using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;      // Takip edilecek araba (araban�n transformu)
    public Vector3 offset;        // Kameran�n araban�n pozisyonuna g�re uzakl���
    private float smoothTime; // Kameran�n yumu�akl�k s�resi

    private Vector3 velocity = Vector3.zero; // SmoothDamp i�in h�z de�i�keni

    private void Start()
    {
        smoothTime = 0.3f;
        transform.position = new Vector3(target.position.x,target.position.y,-24f);
    }

    void LateUpdate()
    {
        // Hedef pozisyonu hesapla
        Vector3 targetPosition = target.position + offset;
        // Kameray� yumu�ak bir �ekilde hedef pozisyona ta��r
        if (CarSkillLevelManager.speedLevel < 5)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
        else if (CarSkillLevelManager.speedLevel <= 7)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime - 0.1f);
            print(smoothTime - 0.1f);
        }
        else if (CarSkillLevelManager.speedLevel > 7)
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime - 0.2f);
            print(smoothTime - 0.2f);
        }
    }
}
