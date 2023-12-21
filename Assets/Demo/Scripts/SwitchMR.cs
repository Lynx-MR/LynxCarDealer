//   ==============================================================================
//   | Lynx Mixed Reality                                                         |
//   |======================================                                      |
//   | Lynx Car Dealer                                                            |
//   | Simple script to switch between AR and VR.                                 |
//   ==============================================================================

using Lynx.UI;
using UnityEngine;

namespace Lynx.CarDealer
{
    public class SwitchMR : MonoBehaviour
    {
        #region INSPECTOR VARIABLES

        [SerializeField] private Camera xrCamera = null;
        //[SerializeField] private GameObject ARText;
        //[SerializeField] private GameObject VRText;
        [SerializeField] private GameObject VREnvironment;
        [SerializeField] private LynxToggleButton ButtonArVr;
        //[SerializeField] private LynxToggleButton ButtonColor;
        [SerializeField] private float timeDisabled = 1;

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// Call this function to switch to VR.
        /// </summary>
        public void SwitchVR()
        {
            LynxAPI.SetVR();
            xrCamera.clearFlags = CameraClearFlags.Skybox;
            //VRText.SetActive(false);
            //ARText.SetActive(true);
            VREnvironment.SetActive(true);
            ButtonArVr.interactable = false;
            //ButtonColor.interactable = false;
            Invoke("SetButtonInteractable", timeDisabled);
        }

        /// <summary>
        /// Call this function to switch to AR.
        /// </summary>
        public void SwitchAR()
        {
            LynxAPI.SetAR();
            xrCamera.clearFlags = CameraClearFlags.SolidColor;
            //VRText.SetActive(true);
            //ARText.SetActive(false);
            VREnvironment.SetActive(false);
            ButtonArVr.interactable = false;
            //ButtonColor.interactable = false;
            Invoke("SetButtonInteractable", timeDisabled);
        }

        private void SetButtonInteractable()
        {
            ButtonArVr.interactable = true;
            //ButtonColor.interactable = true;
        }
        #endregion
    }
}