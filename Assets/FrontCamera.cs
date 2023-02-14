using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.XR.WSA.WebCam;

public class FrontCamera : MonoBehaviour
{
    // Start is called before the first frame update
    // WebCamTexture webcam;
    // Texture2D Tex2d;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        for(int i = 0 ; i < devices.Length ; i++){
            Debug.Log("カメラ" + devices[i].name);
        }

        // webcam = new WebCamTexture("MN34150", 896, 504,15);
        // Tex2d = new Texture2D(896, 504, TextureFormat.RGBA32, false);
        // webcam.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
