/* Julian Salgado
 * Assignment 2
 * UImanager.cs
 * Manages character stats UI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
 
    public Text stats;

    public Character c;

    // Start is called before the first frame update
    void Start()
    {
        if (stats == null)
        {
            stats = FindObjectOfType<Text>();
        }

        if (c == null)
        {
            c = GameObject.FindGameObjectWithTag("Character").GetComponent<Character>();
        }

        stats.text = "Attack: " + c.attack + "\nSpeed: " + c.speed + "\nDefense: " + c.defense;
    }

    // Update is called once per frame
    void Update()
    {
        stats.text = "Attack: " + c.attack + "\nSpeed: " + c.speed + "\nDefense: " + c.defense;
    }
}
