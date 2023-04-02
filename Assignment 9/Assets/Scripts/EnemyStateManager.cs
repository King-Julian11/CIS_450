/* Julian Salgado
 * EnemyStateManager.cs
 * Assignment 9
 * Manages enemy states
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    public EnemyState returnToStartState { get; set; }
    public EnemyState idleState { get; set; }
    public EnemyState moveState { get; set; }
    public EnemyState currentState { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        idleState = gameObject.AddComponent<IdleState>();
        moveState = gameObject.AddComponent<MoveState>();
        returnToStartState = gameObject.AddComponent<ReturnToStartState>();

        currentState = idleState;
    }

    public void StartChasing() { currentState.StartChasing(); }
    public void ChargeAttack() { currentState.ChargeAttack(); }
    public void StopChasingAndReturnToStart() { currentState.StopChasingAndReturnToStart(); }
    public void ReturnedAndReady() { currentState.ReturnedAndReady(); }
}
