using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CS_toMotion : MonoBehaviour
{

    public VideoPlayer fromMov;
    public VideoPlayer toMov;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Clicked()
    {
        toMov.url = fromMov.url;
    }
}
