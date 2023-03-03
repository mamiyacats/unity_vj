using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_all_StartRes : MonoBehaviour
{

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        Debug.Log("After Scene is loaded and game is running.");
        Screen.SetResolution(1920, 1080, false);
    }
}


