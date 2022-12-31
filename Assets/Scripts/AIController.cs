using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }
}
