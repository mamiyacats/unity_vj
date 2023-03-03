
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[RequireComponent(typeof(RawImage), typeof(VideoPlayer), typeof(AudioSource))]
public class CS_RawWait : MonoBehaviour
{
    RawImage image;
    VideoPlayer player;

    public RenderTexture rtFromVideo;
    public RawImage rtToVideo;
    public string TexName; 
   
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
        rtToVideo.material = rtToVideo.GetComponent<RawImage>().material;

    }


    void Update()
    {
        this.material.SetTexture("_MainTex", rtFromVideo);
        rtToVideo.material.SetTexture(TexName, rtFromVideo);
    }

}