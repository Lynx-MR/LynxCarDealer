//   ==============================================================================
//   | Lynx Mixed Reality                                                         |
//   |======================================                                      |
//   | Lynx Car Dealer                                                            |
//   | Script to change the color of the car.                                     |
//   ==============================================================================

using UnityEngine;

namespace Lynx.CarDealer
{
    public class ChangeColor : MonoBehaviour
    {
        #region INSPECTOR VARIABLES

        [Tooltip("Fill here different colors you want yo set on your object.")]
        [SerializeField] private Color[] m_colors = null; 

        #endregion

        #region PRIVATE VARIABLES

        private Renderer m_renderer = null; // Store object renderer.

        #endregion

        #region UNITY API

        // Start is called before the first frame update.
        private void Start()
        {
            // At begining, store object renderer (optimized to avoid lossy GetComponent() function)
            m_renderer = this.GetComponent<Renderer>();
            if (!m_renderer)
                Debug.LogError("There is no renderer on this object --> Cannot change its color");
        }

        #endregion

        #region PUBLIC METHODS

        /// <summary>
        /// Change current object color with the color at same index;
        /// </summary>
        /// <param name="idx">Index of the color to display.</param>
        public void ChangeColorByIndex(int idx)
        {
            // Check current object can change its color.
            if (!m_renderer)
            {
                Debug.LogError("No way, this object does not have renderer.");
                return;
            }

            // Check that given index is valid.
            if (idx < 0 || idx > m_colors.Length)
            {
                Debug.LogError($"Color at index {idx} is invalid.");
                return;
            }

            // Change object color.
            m_renderer.material.color = m_colors[idx];
        }

        /// <summary>
        /// Set specified color on the object.
        /// </summary>
        /// <param name="color">Color to apply on the object.</param>
        public void SetColor(Color color)
        {
            // Check current object can change its color.
            if (!m_renderer)
            {
                Debug.LogError("No way, this object does not have renderer.");
                return;
            }

            // Set object color
            m_renderer.material.color = color;
        }

        #endregion
    }
}