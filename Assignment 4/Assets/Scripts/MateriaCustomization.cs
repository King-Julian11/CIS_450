/* Julian Salgado
 * MateriaCustomization.cs
 * Assignment 4
 * Manages materia customization
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MateriaCustomization : MonoBehaviour
{
    public Materia materia;

    public void setType(string newMateria)
    {
        switch (newMateria)
        {
            case "Light":
                this.materia = new LightMateria();
                break;
            case "Heavy":
                this.materia = new HeavyMateria();
                break;
            default:
                Debug.LogError("No type called" + newMateria);
                break;
        }
        materiaDisplay();
    }

    public void setElement(string newElement)
    {
        switch (newElement)
        {
            case "Fire":
                this.materia = new Fire(materia);
                GameObject.FindGameObjectWithTag("Materia").GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "Blizzard":
                this.materia = new Blizzard(materia);
                GameObject.FindGameObjectWithTag("Materia").GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case "Thunder":
                this.materia = new Thunder(materia);
                GameObject.FindGameObjectWithTag("Materia").GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
        }
        materiaDisplay();
    }

    public void materiaDisplay()
    {
        gameObject.GetComponent<Text>().text = materia.getDescription() 
            + "\nDamage: " + materia.getDamage() + "\nSpeed: " + materia.getSpeed();
    }
}
