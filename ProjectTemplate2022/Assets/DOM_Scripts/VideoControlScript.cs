using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoControlScript : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] string sceneName;

    void Start()
    {
        videoPlayer = this.GetComponent<VideoPlayer>();
    }

    void Update()
    {
        PlayVideo();
    }

    private void PlayVideo()
    {
        //check if video is loaded on video player
        if (videoPlayer.length > 1)
        {
            //check if video is done playing
            if (videoPlayer.isPlaying == false)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
