using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPanel : MonoBehaviour
{
    Animator animator;
    [SerializeField] private float respawnCD;
    private void Awake()
    {
        FallingCollider.OnCarFell += AnimationTrigger;
        respawnCD = 2f;
    }
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (respawnCD > 0)
        {
            respawnCD -= Time.deltaTime;
        }
        if (respawnCD <= 0)
        {
            respawnCD = 0;
        }
    }
    public void AnimationTrigger()
    {
        if (respawnCD <= 0)
        {
            animator.SetTrigger("Kararma");
            respawnCD = 2f;
        }
    }
    public void AnimationEvent_Respawn()
    {
        FallingCollider.OnCarRespawn?.Invoke();
    }
}
