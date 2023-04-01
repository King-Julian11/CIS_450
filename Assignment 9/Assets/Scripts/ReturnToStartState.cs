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
        //If the enemy is returning to its start position and sees the player
        //The enemy could chase the player:
        Debug.Log("The enemy sees you and continues chasing you.");
        agent.SetDestination(player.transform.position);
        enemyStateManager.currentState = enemyStateManager.moveState;
    }

    public override IEnumerator ChargeAttack()
    {
        Debug.Log("Player got close enough for the enemy to attack, but the enemy was returning to its start position.");
        agent.SetDestination(startPosition);
        yield return null;
    }

    public override void StopChasingAndReturnToStart()
    {
        Debug.Log("Enemy tried to stop chasing and return, but the enemy was already returning to its start position.");
    }

    public override void RecoverFromDazed()
    {
        Debug.Log("Enemy tried to recover from being dazed, but the enemy was returning to its start position.");
    }

    public override void ReturnedAndReady()
    {
        enemyStateManager.currentState = enemyStateManager.idleState;
    }
}
