using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAISagdanSola : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = Random.Range(2.5f, 5f);

        animator = GetComponent<Animator>();
        if (navMeshAgent.speed < 3.5f)
        {
            animator.speed = 1;
        }
        else
        {
            animator.speed = navMeshAgent.speed / 3.5f;
        }

        float scale = Random.Range(1.1f, 1.4f);
        transform.localScale = new Vector3(
            transform.localScale.x * scale,
            transform.localScale.y * scale,
            transform.localScale.z * scale);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hedef = new Vector3(-72, 1, 3.5f);
        navMeshAgent.SetDestination(hedef);
        if (Vector3.Distance(transform.position, hedef) < 2)
        {
            Destroy(gameObject);
        }
    }
}
