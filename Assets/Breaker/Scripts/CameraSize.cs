using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour {
    
    float screenAspectRatio = 0;

    void Start() {
        screenAspectRatio = (float)Screen.width / (float)Screen.height;
        float size = (float)(6 - (screenAspectRatio - 0.5) * 11.66);
        if(size <= 5.3f) {
            Camera.main.fieldOfView  = 65;
        }else {
            Camera.main.fieldOfView  = 65 + size;
        }
    }
}
