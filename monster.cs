using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Antogonist : MonoBehaviour
{
    public Transform player;
    public float speed = 10f;
    public float detectionRange = 20f;
    public AudioSource zvuk;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer > detectionRange)
        {
            agent.SetDestination(RandomPointInNavMesh());
               
        }
        else
        {
            agent.SetDestination(player.position);
            zvuk.Play();
        }
    }

    Vector3 RandomPointInNavMesh()
    {
        Vector3 randomDirection = Random.insideUnitCircle * 10f;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, 10f, NavMesh.AllAreas);

        return hit.position;
    }
}


