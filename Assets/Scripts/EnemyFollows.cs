using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollows : MonoBehaviour
{
    #region Variables
    private UnityEngine.AI.NavMeshAgent agent;
    public Transform target;
    #endregion


    
    void Awake()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
      agent.SetDestination(target.position);  
    }
}
