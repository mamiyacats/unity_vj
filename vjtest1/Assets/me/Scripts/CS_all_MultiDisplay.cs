using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_all_MultiDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxDisplayCount = 2;
        for(int i = 0; i<maxDisplayCount && i<Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
