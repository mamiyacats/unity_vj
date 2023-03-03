
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class CS_writeRT : MonoBehaviour
{
    RawImage image;
    VideoPlayer player;


    [SerializeField] RawImage inputImage;
    [SerializeField] RenderTexture renderOut;

    private Material material;



    void Start()
    {

    }


    void Update()
    {
        Texture2D texture = inputImage.texture as Texture2D;
        Graphics.Blit(texture,renderOut,inputImage.material);

    }


}