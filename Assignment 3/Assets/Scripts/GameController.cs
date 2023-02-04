using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject sphere;
    public Observer box1;
    public Observer box2;
    public Observer box3;

    //public GameObject box1;
    //public GameObject box2;
    //public GameObject box3;

    Subject subject = new Subject();

    // Start is called before the first frame update
    void Start()
    {
        Observer first = new Box(box1, new JumpLow());
        Observer second = new Box(box2, new JumpMed());
        Observer third = new Box(box3, new JumpHigh());

        subject.AddObserver(first);
        subject.AddObserver(second);
        subject.AddObserver(third);
    }

    // Update is called once per frame
    void Update()
    {
        if ((sphere.transform.position).magnitude < 0.5f)
        {
            subject.Notify();
        }
    }
}
