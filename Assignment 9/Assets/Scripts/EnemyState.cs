/* Julian Salgado
 * EnemyState.cs
 * Assignment 9
 * Abstract class for enemy states
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyState : MonoBehaviour
{
    public abstract void StartChasing();
    public abstract IEnumerator ChargeAttack();
    public abstract void StopChasingAndReturnToStart();
    public abstract void ReturnedAndReady();
}
