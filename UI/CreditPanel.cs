using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditPanel : MonoBehaviour
{

    public GameObject creditsPanel;

    public void closepanel() {
        creditsPanel.transform.localScale = Vector3.zero;
    }

}
