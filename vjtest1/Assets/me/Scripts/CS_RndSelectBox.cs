using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Linq;
using System.IO;

public class CS_RndSelectBox : MonoBehaviour
{

    [SerializeField] GameObject textInput;
    InputField inputText;
    public List<string> movPaths = new List<string>();
    public int fileCount;
    

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
        inputText = textInput.GetComponent<InputField>();

        string fldPath = inputText.text;

        fileCount = Directory.GetFiles(fldPath, "*.mp4", SearchOption.TopDirectoryOnly).Length;
        
        DirectoryInfo dir = new DirectoryInfo(fldPath);
        FileInfo[] info = dir.GetFiles("*.mp4");

        //Debug.Log(fileCount);       

        foreach(FileInfo f in info)
        {
            movPaths.Add(f.FullName);
        }

        Debug.Log("Listed!");


    }





    
}
