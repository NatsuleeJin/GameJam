using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace code
{
    public class VdoEnd : MonoBehaviour
    {
        public VideoPlayer videoPlayer;

        private void OnValidate()
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        public void OnEnable()
        {
            videoPlayer.loopPointReached += EndReached;
        }

        private void OnDestroy()
        {
            videoPlayer.loopPointReached -= EndReached;
        }

        private void EndReached(VideoPlayer source)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}