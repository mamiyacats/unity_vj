using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CS_fadeVideo : MonoBehaviour
{

    [SerializeField] RawImage toMovRaw;
    [SerializeField] float fadeSecondes;
    public bool checkFade;
    public string FaderName;
    float fade;
    float fade01;


    [SerializeField] VideoPlayer waitAvideo;
    [SerializeField] VideoPlayer waitBvideo;
    [SerializeField] CS_dialog dialog;
    [SerializeField] CS_dialogTo dialogto;
    
    VideoPlayer playerA;
    VideoPlayer playerB;

    List<string> outDir;



    private Material material;



    // Start is called before the first frame update
    void Start()
    {
        checkFade = false;
        fade = 0;
        toMovRaw.material = toMovRaw.GetComponent<RawImage>().material;

        playerA = waitAvideo.GetComponent<VideoPlayer>();
        playerB = waitBvideo.GetComponent<VideoPlayer>();

        outDir = new List<string>();


    }

    // Update is called once per frame
    void Update()
    {


        if (checkFade == true)
        {

            fade += Time.deltaTime;
            fade01 = Mathf.Clamp01(fade);

            toMovRaw.material.SetFloat(FaderName, fade01);

            
        }
        
        if (checkFade == false)
        {

            fade -= Time.deltaTime;
            fade01 = Mathf.Clamp01(fade);

            toMovRaw.material.SetFloat(FaderName, fade01);

            
        }

    }





    public void ClickFade()
    {
        if(checkFade == false)
            {
                checkFade = true;
                fade = 0;
            }
        else if(checkFade == true)
            {
                checkFade = false;
                fade = 1;
            }
        

        Invoke("ClickSelect", 1.1f);
        Invoke("reloadMov", 1.1f);
       

    }



    public void ClickSelect()
    {
        //int count = dialog.fileCount;
        int sON = dialog.sON;
        //int sON = dialog.sson;
        int count = dialog.fileCounts[sON];
        //Debug.Log(sson);

        int rndFigure = RandomInt(count);

        /*
        string pathName = dialog.movPathOut[rndFigure];


        if(checkFade == false)
        {
            playerB.url = pathName;
        }
        else if(checkFade == true)
        {
            playerA.url = pathName;
        }
        */

        //dialogto.clickdOuter();

        
    }


    int RandomInt(int count)
    {
        int max = count;

        System.Random random = new System.Random();
        int randomInt = random.Next(0, max);


        return randomInt;
        
        
    }





    public void reloadMov()
    {
        int swtInt = dialogto.switchInt;
        outDir = dialog.Par_movPath[swtInt];

        int count = dialogto.count;
        int rndFigure = RandomInt(count);
        string pathName = outDir[rndFigure];



        if (checkFade == false)
        {
            playerB.url = pathName;
        }
        else if (checkFade == true)
        {
            playerA.url = pathName;
        }




    }



}
