/* Julian Salgado
 * MoveState.cs
 * Assignment 9
 * Moving state for enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveState : EnemyState
{
    EnemyStateManager enemyStateManager;
    NavMeshAgent agent;
    GameObject player;
    Vector3 startPosition;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        enemyStateManager = gameObject.GetComponent<EnemyStateManager>();
        agent = gameObject.GetComponent<NavMeshAgent>();
        rb = gameObject.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        startPosition = gameObject.transform.position;
    }

    public override void StartChasing()
    {
        agent.SetDestination(player.transform.position);
    }

    public override IEnumerator ChargeAttack()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

        Vector3 pushDirection = (player.transform.position - transform.position).normalized;
        rb.AddForce(pushDirection * 300f, ForceMode.Impulse);

        yield return new WaitForSeconds(0.15f);

        Rigidbody playerRB = player.GetComponent<Rigidbody>();
        playerRB.AddForce(pushDirection * 500f, ForceMode.Impulse);
    }

    public override void StopChasingAndReturnToStart()
    {
        agent.SetDestination(startPosition);
        enemyStateManager.currentState = enemyStateManager.returnToStartState;
    }

    public override void ReturnedAndReady()
    {
        
    }
}
