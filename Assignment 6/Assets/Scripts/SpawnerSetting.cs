/* Julian Salgado
 * SpawnerSetting.cs
 * Assignment 6
 * Displays text to communicate to the player on what car brand will be spawned
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerSetting : MonoBehaviour
{
    public GameObject carSpawner;
    public CarSpawner carSpawnerScriptInstance;

    // Start is called before the first frame update
    void Start()
    {
        carSpawnerScriptInstance = carSpawner.GetComponent<CarSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        string displayText = "";

        if (carSpawnerScriptInstance.isFord)
        {
            displayText = "Spawner Setting: Ford";
        }
        else if (!carSpawnerScriptInstance.isFord)
        {
            displayText = "Spawner Setting: Toyota";
        }

        gameObject.GetComponent<Text>().text = displayText;
    }
}
