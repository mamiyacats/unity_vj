using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Windows.Forms;
using System.IO;
using System.Linq;





public class CS_dialog : MonoBehaviour
{

    [SerializeField] GameObject textInput;
    //[SerializeField] GameObject textInput2;
    [SerializeField] EventSystem eventSystem;
    InputField inputText;
    InputField inTxt;
    public int sON;
    string DirName;
    //GameObject selectedObject;


    //public List<string> movPath;
    public List<string> movPath0;
    public List<string> movPath1;
    public List<string> movPath2;
    public List<string> movPath3;
    public List<string> movPath4;
    //public List<string> movPathOut;
    public List<List<string>> Par_movPath;

    //public List<string> movPaths = new List<string>();
    //public List<List<string>> Par_movPaths = new List<List<string>>();

    public int fileCount;
    public List<int> fileCounts;

    public List<InputField> Inputs;




    // Start is called before the first frame update
    void Start()
    {
        sON = 0;

        //movPath = new List<string>();
        movPath0 = new List<string>();
        movPath1 = new List<string>();
        movPath2 = new List<string>();
        movPath3 = new List<string>();
        movPath4 = new List<string>();
        //movPathOut = new List<string>();
        Par_movPath = new List<List<string>>();
        fileCounts = new List<int>();

        Par_movPath.Add(movPath0);
        Par_movPath.Add(movPath1);
        Par_movPath.Add(movPath2);
        Par_movPath.Add(movPath3);
        Par_movPath.Add(movPath4);

        fileCounts.Add(0);
        fileCounts.Add(0);
        fileCounts.Add(0);
        fileCounts.Add(0);
        fileCounts.Add(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public bool OpenFile()
    {
        inputText = Inputs[sON].GetComponent<InputField>();

        OpenFileDialog ofd = new OpenFileDialog();

        //ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        ofd.Title = "Select Folder.";
        ofd.InitialDirectory = @"C:";
        ofd.FileName = "Select Folder";
        ofd.Filter = "Folder|*.";
        ofd.ValidateNames = false;
        ofd.CheckFileExists = false;
        ofd.CheckPathExists = true;

        if (DialogResult.OK == ofd.ShowDialog())
        {
            inputText.text = Path.GetDirectoryName(ofd.FileName);
            return true;
        }
        else return false;
    }




    public void OpenDialog()
    {
        inTxt = textInput.GetComponent<InputField>();

        OpenFileDialog ofd = new OpenFileDialog();

        //ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        ofd.Title = "Select Folder.";
        ofd.InitialDirectory = @"C:";
        ofd.FileName = "Select Folder";
        ofd.Filter = "Folder|*.";
        ofd.ValidateNames = false;
        ofd.CheckFileExists = false;
        ofd.CheckPathExists = true;

        ofd.ShowDialog();
        //string filePath = ofd.FileName;

        inTxt.text = Path.GetDirectoryName(ofd.FileName);
    }





    public void OpenFile2()
    {
        //inputText = textInput2.GetComponent<InputField>();

        OpenFileDialog ofd = new OpenFileDialog();

        //ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        ofd.Title = "Select Folder.";
        ofd.InitialDirectory = @"C:";
        ofd.FileName = "Select Folder";
        ofd.Filter = "Folder|*.";
        ofd.ValidateNames = false;
        ofd.CheckFileExists = false;
        ofd.CheckPathExists = true;

        ofd.ShowDialog();
        //string filePath = ofd.FileName;

        inputText.text = Path.GetDirectoryName(ofd.FileName);


        Listed(inputText.text);
    }





    public void OpenAndListed()
    {
        GameObject selectedObject = eventSystem.currentSelectedGameObject.gameObject;
        string selectedObjectName = selectedObject.name.Remove(0, 6);
        sON = int.Parse(selectedObjectName);

        if (!OpenFile()) return;
        
        Listed(inputText.text);
    }



    public void OpenAndListed2()
    {
        if (!OpenFile()) return;

        GameObject selectedObject = eventSystem.currentSelectedGameObject.gameObject;
        string selectedObjectName = selectedObject.name.Remove(0, 6);
        sON = int.Parse(selectedObjectName);

        /*
        ToggleGroup tglGr = GetComponent<ToggleGroup>();
        Toggle tgl = tglGr.ActiveToggles().FirstOrDefault();
        string tglInt = tgl.name.Remove(0, 6);
        sON = int.Parse(tglInt);
        //Debug.Log(sON);
        */

        //[sON].Add(inputText.text);

        Listed(inputText.text);
        //movPathOut = Par_movPath[sON];



    }

    




    public void Listed(string inputText)
    {

        Par_movPath[sON].Clear();

        string fldPath = inputText;

        int mp4Count = Directory.GetFiles(fldPath, "*.mp4", SearchOption.TopDirectoryOnly).Length;
        int movCount = Directory.GetFiles(fldPath, "*.mov", SearchOption.TopDirectoryOnly).Length;
        fileCount = mp4Count + movCount;
        fileCounts[sON] = fileCount;

        DirectoryInfo dir = new DirectoryInfo(fldPath);

        FileInfo[] info = dir.GetFiles("*.mp4");
        foreach (FileInfo f in info)
        {
            Par_movPath[sON].Add(f.FullName);            
        }
        info = dir.GetFiles("*.mov");
        foreach (FileInfo f in info)
        {
            Par_movPath[sON].Add(f.FullName);
        }     
        Debug.Log("Listed!");
    }

}
