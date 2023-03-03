using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using System.Linq;

public class CS_fromToggle : MonoBehaviour
{

    [SerializeField] RawImage toMovRaw;

    private Material material;

    string FaderName;
    string RepairName;

    public string FaderNameA;
    public string FaderNameB;
    public string FaderNameC;
    public string FaderNameD;


    float tglValue;
    ToggleGroup tglGr;





    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void MovSelect()
    {
        
        tglGr = GetComponent<ToggleGroup>();
        Toggle tgl = tglGr.ActiveToggles().FirstOrDefault();
        RepairName = tgl.name;
        tgl.name = tgl.name.Remove(0, 6);

        FaderName = "_Tex" + tgl.name + "Fader";
        

        toMovRaw.material = toMovRaw.GetComponent<RawImage>().material;
        toMovRaw.material.SetFloat(FaderNameA, 0);
        toMovRaw.material.SetFloat(FaderNameB, 0);
        toMovRaw.material.SetFloat(FaderNameC, 0);
        toMovRaw.material.SetFloat(FaderNameD, 0);

        if (tgl.GetComponent<Toggle>().isOn == true)
        {
            toMovRaw.material.SetFloat(FaderName, 1);
        }

        tgl.name = RepairName;

   

    }
}
