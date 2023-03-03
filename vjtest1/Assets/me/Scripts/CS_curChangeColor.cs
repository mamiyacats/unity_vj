using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CS_curChangeColor : MonoBehaviour
{
    [SerializeField] private Dropdown dropdown;
    [SerializeField] private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    // Update is called once per frame
    public void ChangeColor()
    {
        if(dropdown.value == 0)
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (dropdown.value == 1)
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (dropdown.value == 2)
        {
            cube.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (dropdown.value == 3)
        {
            cube.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (dropdown.value == 4)
        {
            cube.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
