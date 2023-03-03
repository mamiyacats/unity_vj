
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(RawImage), typeof(VideoPlayer), typeof(AudioSource))]
public class CS_materialTest : MonoBehaviour
{
    RawImage image;
    VideoPlayer player;

    public RenderTexture rtFromVideo;
    //private Texture2D tex4shader;
    //private Texture2D tex4shaderB;
    private Material material;

    void Awake()
    {
        image = GetComponent<RawImage>();
        player = GetComponent<VideoPlayer>();
        var source = GetComponent<AudioSource>();
        player.EnableAudioTrack(0, true);
        player.SetTargetAudioSource(0, source);
    }

    void Start()
    {
        this.material = GetComponent<RawImage>().material;
        //tex4shader = new Texture2D(rtFromVideo.width, rtFromVideo.height, TextureFormat.ARGB32, false);
        //tex4shaderB = new Texture2D(512, 512, TextureFormat.ARGB32, false);
    }



    void Update()
    {

        this.material.SetTexture("_MainTex", rtFromVideo);

        /*
        if (rtFromVideo != null) 
        {
            //image.texture = player.texture;
            /*
            RenderTexture.active = rtFromVideo;
            tex4shader.ReadPixels(new Rect(0, 0, rtFromVideo.width, rtFromVideo.height), 0, 0);
            tex4shader.Apply();
            tex4shaderB.ReadPixels(new Rect(0, 0, rtFromVideo.width, rtFromVideo.height), 0, 0);
            tex4shaderB.Apply();
            
            //TranslateRenderTex();
            this.material.SetTexture("_MainTex", rtFromVideo);
        }*/
    }

}