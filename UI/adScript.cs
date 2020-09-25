using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adScript : MonoBehaviour
{
    string gameId = "3776473";
    bool testMode = false;
    public FloatVariable addSomeLioght;

    void Awake()
    {
        Advertisement.Initialize (gameId, testMode);   
    }

    public void ads() {
        Advertisement.Show();
        addSomeLioght.value += 40;
    }


}
