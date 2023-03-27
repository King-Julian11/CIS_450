/* Julian Salgado
 * UItext.cs
 * Assignment 8
 * Manages UI text
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UItext : MonoBehaviour
{
    public Text uiText;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        uiText.text = "Health: " + player.coinCount + "\nMoney: " + player.health;
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = "Health: " + player.coinCount + "\nMoney: " + player.health;
    }
}
