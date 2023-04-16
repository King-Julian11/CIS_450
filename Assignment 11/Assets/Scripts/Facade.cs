/* Julian Salgado
 * Facade.cs
 * Assignment 11
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{

    private GameObject winPlane;
    private WinText winText;

    private void Awake()
    {
        winPlane = GameObject.FindGameObjectWithTag("WinPlane");
        winText = GameObject.FindGameObjectWithTag("WinText").GetComponent<WinText>();
    }

    public void Win()
    {
        StartCoroutine(winText.DisplayText());
    }
}
