using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using System.Linq;

public class cs_test : MonoBehaviour
{

    ToggleGroup gl;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked()
    {

        gl = GetComponent<ToggleGroup>();
        Toggle tgl = gl.ActiveToggles().FirstOrDefault();
        tgl.isOn = false;

    }
}
