//   ==============================================================================
//   | Lynx Mixed Reality                                                         |
//   |======================================                                      |
//   | Lynx Car Dealer                                                            |
//   | Simple script to switch between AR and VR.                                 |
//   ==============================================================================

using UnityEngine;

namespace Lynx.CarDealer
{
    public class SwitchMR : MonoBehaviour
    {
        #region INSPECTOR VARIABLES

        [SerializeField] private Camera xrCamera = null;
        [SerializeField] private GameObject ARText;
        [SerializeField] private GameObject VRText;
        [SerializeField] private GameObject VREnvironment;

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// Call this function to switch to VR.
        /// </summary>
        public void SwitchVR()
        {
            LynxAPI.SetVR();
            xrCamera.clearFlags = CameraClearFlags.Skybox;
            VRText.SetActive(false);
            ARText.SetActive(true);
            VREnvironment.SetActive(true);
        }

        /// <summary>
        /// Call this function to switch to AR.
        /// </summary>
        public void SwitchAR()
        {
            LynxAPI.SetAR();
            xrCamera.clearFlags = CameraClearFlags.SolidColor;
            VRText.SetActive(true);
            ARText.SetActive(false);
            VREnvironment.SetActive(false);
        }

        #endregion
    }
}