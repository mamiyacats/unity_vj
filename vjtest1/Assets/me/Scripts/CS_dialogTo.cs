using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Linq;
using System;

public class CS_dialogTo : MonoBehaviour
{
    public int switchInt;
    public bool check;

    [SerializeField] VideoPlayer waitAvideo;
    [SerializeField] VideoPlayer waitBvideo;

    VideoPlayer playerA;
    VideoPlayer playerB;

    private Material material;
    public CS_fadeVideo fadevideo;
    public CS_dialog dialog;

    List<string> outDir;
    public int count;


    // Start is called before the first frame update
    void Start()
    {

        playerA = waitAvideo.GetComponent<VideoPlayer>();
        playerB = waitBvideo.GetComponent<VideoPlayer>();        

        outDir = new List<string>();

    }


    public void clicked()
    {
        check = fadevideo.checkFade;

        //switch--
        ToggleGroup tglGr = GetComponent<ToggleGroup>();
        Toggle tgl = tglGr.ActiveToggles().FirstOrDefault();
        string switchName = tgl.name.Remove(0, 6);
        switchInt = int.Parse(switchName);
        //--switch

        outDir = dialog.Par_movPath[switchInt];

        /*
        int sON = dialog.sON;
        count = dialog.fileCounts[sON];*/
        count = dialog.fileCounts[switchInt];

        int rndFigure = RandomInt(count);
        string pathName = outDir[rndFigure];

        
        if (check == false)
        {
            playerB.url = pathName;
        }
        else if (check == true)
        {
            playerA.url = pathName;
        }      
    }
    

    public void clickedOuter()
    {

        check = fadevideo.checkFade;
        outDir = dialog.Par_movPath[switchInt];
                       
        int rndFigure = RandomInt(count);
        string pathName = outDir[rndFigure];



        if (check == false)
        {
            playerB.url = pathName;
        }
        else if (check == true)
        {
            playerA.url = pathName;
        }   
    }

    int RandomInt(int count)
    {
        int max = count;

        System.Random random = new System.Random();
            int randomInt = random.Next(0, max);


        return randomInt;
    }    
}
