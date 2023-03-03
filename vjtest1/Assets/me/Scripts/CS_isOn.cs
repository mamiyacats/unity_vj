using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Klak.VJUI;


public class CS_isOn : MonoBehaviour
{
    [SerializeField] Button _button;
    public int isOn;


    // Start is called before the first frame update
    void Start()
    {
        isOn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ButtonDown()
    {
        isOn = 1;
    }

    public void ButtonUp()
    {
        isOn = 0;
    }
}
