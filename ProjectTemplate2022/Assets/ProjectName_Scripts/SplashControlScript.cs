using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class SplashControlScript : MonoBehaviour
{
    [SerializeField] VideoPlayer splashVideoPlayer;
    [SerializeField] string sceneName;

    void Start()
    {
        splashVideoPlayer = this.GetComponent<VideoPlayer>();
    }

    void Update()
    {
        PlayVideo();
    }

    void PlayVideo()
    {
        //check if video is loaded on video player
        if (splashVideoPlayer.length > 1)
        {
            //check if video is done playing
            if (splashVideoPlayer.isPlaying == false)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
