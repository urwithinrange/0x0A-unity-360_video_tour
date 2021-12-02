using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    // private HotSpot livingRoom;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    public void changeRoom(VideoClip video)
    {
        videoPlayer.clip = video;
    }
    IEnumerator playVideo()
    {
       yield return new WaitForSeconds(0.5f);
    }
}
