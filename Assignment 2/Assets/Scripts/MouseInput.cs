/* Julian Salgado
 * Assignment 2
 * MouseInput.cs
 * Detects mouse input for selection
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                Character objectHit = hitInfo.collider.GetComponent<Character>();

                if (objectHit != null)
                {
                    objectHit.selectBuff();

                }
            }
        }
    }
}
