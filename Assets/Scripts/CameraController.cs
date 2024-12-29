using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;      // Takip edilecek araba (arabanýn transformu)
    public Vector3 offset;        // Kameranýn arabanýn pozisyonuna göre uzaklýðý
    private float smoothTime; // Kameranýn yumuþaklýk süresi

    private Vector3 velocity = Vector3.zero; // SmoothDamp için hýz deðiþkeni

    private void Start()
    {
        smoothTime = 0.3f;
        transform.position = new Vector3(target.position.x,target.position.y,-24f);
    }

    void LateUpdate()
    {
        // Hedef pozisyonu hesapla
        Vector3 targetPosition = target.position + offset;
        // Kamerayý yumuþak bir þekilde hedef pozisyona taþýr
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
