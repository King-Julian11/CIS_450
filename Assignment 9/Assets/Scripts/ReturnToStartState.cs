/* Julian Salgado
 * ReturnToStartState.cs
 * Assignment 9
 * Enemy returns to start when player is too far
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ReturnToStartState : EnemyState
{
    EnemyStateManager enemyStateManager;
    NavMeshAgent agent;
    GameObject player;
    Vector3 startPosition;

    public void Start()
    {
        enemyStateManager = gameObject.GetComponent<EnemyStateManager>();
        agent = gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
    }

    public override void StartChasing()
    {
        agent.SetDestination(player.transform.position);
        enemyStateManager.currentState = enemyStateManager.moveState;
    }

    public override IEnumerator ChargeAttack()
    {
        agent.SetDestination(startPosition);
        yield return null;
    }

    public override void StopChasingAndReturnToStart()
    {
       
    }

    public override void ReturnedAndReady()
    {
        enemyStateManager.currentState = enemyStateManager.idleState;
    }
}
