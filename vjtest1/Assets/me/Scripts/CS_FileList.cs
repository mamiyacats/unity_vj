using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.Video;


public class CS_FileList : MonoBehaviour
{

    [SerializeField] GameObject movBox;
    [SerializeField] GameObject parent;
    [SerializeField] GameObject textInput;

    VideoPlayer player;
    InputField inputText;


    public void Clicked()
    {
        player = movBox.GetComponent<VideoPlayer>();
        inputText = textInput.GetComponent<InputField>();

        string pdir = inputText.text;
        if (!System.IO.Directory.Exists(pdir)) return; 

        int fileCount = Directory.GetFiles(pdir, "*.mp4", SearchOption.TopDirectoryOnly).Length;

        DirectoryInfo dir = new DirectoryInfo(pdir);
        FileInfo[] info = dir.GetFiles("*.mp4");

        int i = 0;
        int kis = 0;
        int kkis = 0;

        foreach (FileInfo f in info)
        {
            kis = i % 2;
            kkis = i -kis;

            Debug.Log(f.FullName);
            GameObject prefab = (GameObject)Instantiate(movBox, new Vector3(64.0f +128.0f *kis, -36.0f -36.0f *kkis , 0.0f), Quaternion.identity);
            prefab.transform.SetParent(parent.transform, false);
            prefab.name = movBox.name +"_" +i;

            player.url = f.FullName;
            player.frame = 10;
            player.playbackSpeed = 0;
            i++;            
        }

        info = dir.GetFiles("*.mov");
        foreach (FileInfo f in info)
        {
            kis = i % 2;
            kkis = i - kis;

            Debug.Log(f.FullName);
            GameObject prefab = (GameObject)Instantiate(movBox, new Vector3(64.0f + 128.0f * kis, -36.0f - 36.0f * kkis, 0.0f), Quaternion.identity);
            prefab.transform.SetParent(parent.transform, false);
            prefab.name = movBox.name + "_" + i;

            player.url = f.FullName;
            player.frame = 10;
            player.playbackSpeed = 0;
            i++;
        }
    }
}
