/* Julian Salgado
 * Assignment 2
 * Character.cs
 * Character abstract class
 */

//My original idea was to display the buffed stats.
//However, due to how I implemented the UImanager script,
//the stats displayed are incorrect and I could not find a
//way to update the stats without errors.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public int attack;
    public int speed;
    public int defense;

    public BuffBehavior buffBehavior;

    public virtual void selectBuff()
    {
        buffBehavior.Buff(this.gameObject);
    }

    public abstract void Start();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buffBehavior = ScriptableObject.CreateInstance<BuffAttack>();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buffBehavior = ScriptableObject.CreateInstance<BuffSpeed>();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buffBehavior = ScriptableObject.CreateInstance<BuffDefense>();
        }
    }
}
