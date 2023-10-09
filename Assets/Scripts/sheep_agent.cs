using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sheep_agent: MonoBehaviour
{
    private NavMeshAgent agent;
    public float radius;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(GetSheepPoint.Instance.GetRandomPoint());

        }
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
#endif
}
