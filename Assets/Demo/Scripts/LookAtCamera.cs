//   ==============================================================================
//   | Lynx Mixed Reality                                                         |
//   |======================================                                      |
//   | Lynx Car Dealer                                                            |
//   | Simple script to ensure that the UI faces the user.                        |
//   ==============================================================================

using UnityEngine;

namespace Lynx.CarDealer
{
    public class LookAtCamera : MonoBehaviour
    {
        // Update is called once per frame.
        void Update()
        {
            transform.LookAt(Camera.main.transform);
        }
    }
}