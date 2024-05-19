using System;
using code.UI;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace code
{
    public class VdoEnd : MonoBehaviour
    {
        public bool ending1N = false;
        public bool ending1S = false;
        public bool ending1P = false;
        public bool ending2 = false;
        public bool ending3 = false;
        public bool ending4 = false;
        
        public VideoPlayer videoPlayer;
        public string assetName;

        private void OnValidate()
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        public void Start()
        {
            videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, assetName);
            videoPlayer.Play();
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

            if (ending1N)
            {
                Gallery.ending1N = true;
            }

            if (ending1S)
            {
                Gallery.ending1S = true;
            }

            if (ending1P)
            {
                Gallery.ending1P = true;
            }

            if (ending2)
            {
                Gallery.ending2 = true;
            }

            if (ending3)
            {
                Gallery.ending3 = true;
            }

            if (ending4)
            {
                Gallery.ending4 = true;
            }
        }
    }
}