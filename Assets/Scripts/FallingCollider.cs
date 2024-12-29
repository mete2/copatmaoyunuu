using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCollider : MonoBehaviour
{
    public static Action OnCarFell;
    public static Action OnCarRespawn;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            OnCarFell?.Invoke();
        }
    }
}
