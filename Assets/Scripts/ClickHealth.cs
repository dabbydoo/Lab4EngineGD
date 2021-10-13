using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickHealth : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        HealthText.Instance.TakeDamage(10);
        #region observer
        clicked?.Invoke();
        #endregion
    }
}
