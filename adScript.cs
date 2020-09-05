using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
// com.marketdude.FlyingRay

/*
The addictive mega-hit Flying Ray is now out for Android! Enjoy this super-duper sensation now!



"In every treasure hunting adventure movie there’s one scene in which the plucky hero finally gets his hands on the treasure but then has to
 navigate a maze of booby traps in order to get out alive. Temple Run is this scene and nothing else. And it’s amazing." - SlideToPlay.com
*/
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
