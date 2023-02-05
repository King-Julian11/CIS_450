/* Julian Salgado
 * GameController.cs
 * Assignment 3
 * GameController script to manage the sphere and boxes.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject sphere;

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;

    Subject subject = new Subject();

    public Movement character;

    // Start is called before the first frame update
    void Start()
    {
        character = gameObject.GetComponent<Movement>();

        Box first = new Box(box1, new JumpLow());
        Box second = new Box(box2, new JumpMed());
        Box third = new Box(box3, new JumpHigh());

        subject.AddObserver(first);
        subject.AddObserver(second);
        subject.AddObserver(third);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            subject.Notify();
        }
    }
}
