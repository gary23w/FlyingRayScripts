using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   public FloatVariable light;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void addLightForTesting() {
        light.value += 1000;
    }
}
