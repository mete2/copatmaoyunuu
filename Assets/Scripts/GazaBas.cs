using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GazaBas : MonoBehaviour
{
    public bool sagaBas;
    public bool solaBas;
    public float speed;
    private int speedLimit = 100;
    [SerializeField] List<Wheel> wheel;
    [SerializeField] private float accelerateAmount;
    [SerializeField] private bool isGrounded;
    
    public void ButtonDown_SagaBas()
    {
        sagaBas = true;
    }
    public void ButtonUp_SagaBas()
    {
        sagaBas = false;
    }
    public void ButtonDown_SolaBas()
    {
        solaBas = true;
    }
    public void ButtonUp_SolaBas()
    {
        solaBas = false;
    }
    void Start()
    {
        accelerateAmount = 1.5f;
    }

    private void Update()
    {
        foreach (Wheel wheel in wheel)
        {
            if (wheel.isGrounded == true)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
        }
        if (isGrounded == true)
        {
            if (sagaBas)
            {
                speed += (int)(Time.fixedDeltaTime * 100 * accelerateAmount);
            }
            else if (solaBas)
            {
                speed -= (int)(Time.fixedDeltaTime * 100 * accelerateAmount);
            }
            if (sagaBas == false && solaBas == false)
            {
                if (speed > 1)
                {
                    speed -= (int)(Time.fixedDeltaTime * 100 * accelerateAmount);
                }
                else if (speed < -1)
                {
                    speed += (int)(Time.fixedDeltaTime * 100 * accelerateAmount);
                }
                else
                {
                    speed = 0;
                }
            }

            if (speed < -speedLimit)
            {
                speed = -speedLimit;
            }
            if (speed > speedLimit)
            {
                speed = speedLimit;
            }
        }
        else
        {
            if (speed > 1)
            {
                speed -= (int)(Time.fixedDeltaTime * 100 * accelerateAmount/10);
            }
            else if (speed < -1)
            {
                speed += (int)(Time.fixedDeltaTime * 100 * accelerateAmount/10);
            }
            else
            {
                speed = 0;
            }
        }
    }
}
