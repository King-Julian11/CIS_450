/* Julian Salgado
 * IdleState.cs
 * Assignment 9
 * Idle state for enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IdleState : EnemyState
{
    EnemyStateManager enemyStateManager;
    NavMeshAgent agent;
    Transform target;

    // Start is called before the first frame update
    public void Start()
    {
        this.enemyStateManager = gameObject.GetComponent<EnemyStateManager>();
        this.agent = gameObject.GetComponent<NavMeshAgent>();
        this.target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public override void StartChasing()
    {
        agent.SetDestination(target.position);
        enemyStateManager.currentState = enemyStateManager.moveState;
    }

    public override IEnumerator ChargeAttack()
    {
        yield return null;
    }

    public override void StopChasingAndReturnToStart()
    {
        
    }

    public override void ReturnedAndReady()
    {
        
    }
}
