using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lynx.UI;

public class TimerButton : MonoBehaviour
{
    #region INSPECTOR VARIABLES


    [SerializeField] private LynxToggleButton ButtonColor;
    [SerializeField] private float timeDisabled = 1;

    #endregion

    public void OnDisable()
    {
        ButtonColor.interactable = false;
        Invoke("SetButtonColorInteractable", timeDisabled);

    }

    private void SetButtonColorInteractable()
    {
        ButtonColor.interactable = true;
    }
}
