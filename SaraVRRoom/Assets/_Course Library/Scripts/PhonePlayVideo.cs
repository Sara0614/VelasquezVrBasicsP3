using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PhonePlayVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Called by XR trigger
    public void PlayVideo()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }
}

