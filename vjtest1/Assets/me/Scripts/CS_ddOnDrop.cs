using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using UnityEditor;

public class CS_ddOnDrop : MonoBehaviour, IDropHandler
{

    VideoPlayer player;
    VideoPlayer toPlayer;
    

    public void OnDrop(PointerEventData eventData)
    {
        if (!eventData.pointerDrag.GetComponent<VideoPlayer>()) return;
        player = eventData.pointerDrag.GetComponent<VideoPlayer>();
        toPlayer = GetComponent<VideoPlayer>();

        toPlayer.url = player.url;
        toPlayer.isLooping = true;

        Debug.Log("OnDrop");
        Debug.Log(eventData.pointerDrag.name);
    }

}
