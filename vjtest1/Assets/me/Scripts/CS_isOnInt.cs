using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Klak.VJUI;
using System;


public class CS_isOnInt : MonoBehaviour
{
    [SerializeField] Toggle _toggle;
    public int isOnInt;

    // Start is called before the first frame update
    void Start()
    {
        isOnInt = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Clicked()
    {
        isOnInt = Convert.ToInt32(_toggle.isOn);
    }
}
