using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

//[RequireComponent(typeof(RawImage), typeof(VideoPlayer), typeof(AudioSource))]
[RequireComponent(typeof(RawImage), typeof(VideoPlayer))]
public class CS_RawBank : MonoBehaviour
{
    RawImage image;
    VideoPlayer player;

    void Awake()
    {
        image = GetComponent<RawImage>();
        player = GetComponent<VideoPlayer>();
        //var source = GetComponent<AudioSource>();
        player.EnableAudioTrack(0, true);
        //player.SetTargetAudioSource(0, source);
    }
    void Update()
    {
        if (player.isPrepared)
        {
            image.texture = player.texture;
        }
    }


}