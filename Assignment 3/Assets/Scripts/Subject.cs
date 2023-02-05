/* Julian Salgado
 * Subject.cs
 * Assignment 3
 * Subject script to notify the observers.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject
{
    List<Observer> observers = new List<Observer>();

    public void Notify()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify();
        }
    }

    public void AddObserver(Box obj)
    {
        observers.Add(obj);
    }
}
