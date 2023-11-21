//   ==============================================================================
//   | Lynx Mixed Reality                                                         |
//   |======================================                                      |
//   | Lynx Car Dealer                                                            |
//   | Simple script to launch the hand menu explanation video.                   |
//   ==============================================================================

using UnityEngine;
using UnityEngine.Video;

namespace Lynx.CarDealer
{
    public class TimerVideo : MonoBehaviour
    {
        #region INSPECTOR VARIABLES

        [SerializeField] private VideoPlayer videoPlayer;
        [SerializeField] private float playTime = 15f;

        #endregion

        #region UNITY API

        // Start is called before the first frame update.
        void Start()
        {
            videoPlayer.Play();
            Invoke("StopVideo", playTime);
        }

        #endregion

        #region PRIVATE METHODS

        /// <summary>
        /// Call this function to stop the video.
        /// </summary>
        private void StopVideo()
        {
            videoPlayer.Stop();
        }

        #endregion
    }
}