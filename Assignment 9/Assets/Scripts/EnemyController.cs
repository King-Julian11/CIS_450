/* Julian Salgado
 * EnemyController.cs
 * Assignment 9
 * Manages enemy movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public ThirdPersonCharacter character;

    public Transform target;
    public Vector3 startPosition;

    public EnemyStateManager enemyStateManager;

    public float detectionRange;
    public float distanceFromPlayer;
    public float distanceFromStart;

    void Start()
    {
        agent.updateRotation = false;

        startPosition = transform.position;

        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        distanceFromPlayer = Vector3.Distance(target.position, transform.position);

        distanceFromStart = Vector3.Distance(startPosition, transform.position);

        if (distanceFromPlayer <= detectionRange)
        {

            enemyStateManager.currentState.StartChasing();

            if (distanceFromPlayer <= 12f)
            {
                Debug.Log("Enemy is close enough to attack");
                StartCoroutine(enemyStateManager.currentState.ChargeAttack());
            }

        }
        else if (distanceFromStart > 12f && (enemyStateManager.currentState != enemyStateManager.returnToStartState))
        {
            enemyStateManager.currentState.StopChasingAndReturnToStart();
        }
        else if (distanceFromStart <= 12f && (enemyStateManager.currentState != enemyStateManager.idleState))
        {
            enemyStateManager.currentState.ReturnedAndReady();
        }


        if (agent.remainingDistance > 12f)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }

    }
}
