using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSizing : MonoBehaviour
{
    public Camera camera1;
    public Material camera1material;

    public Camera camera2;
    public Material camera2material;

    public Camera camera3;
    public Material camera3material;

    public Camera camera4;
    public Material camera4material;

    public Camera camera5;
    public Material camera5material;

    public Camera camera6;
    public Material camera6material;

    void Start()
    {
        if (camera1.targetTexture != null)
        {
            camera1.targetTexture.Release();
        }    

        camera1.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera1material.mainTexture = camera1.targetTexture;

        if (camera2.targetTexture != null)
        {
            camera2.targetTexture.Release();
        }    

        camera2.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera2material.mainTexture = camera2.targetTexture;

        if (camera3.targetTexture != null)
        {
            camera3.targetTexture.Release();
        }    

        camera3.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera3material.mainTexture = camera3.targetTexture;

        if (camera4.targetTexture != null)
        {
            camera4.targetTexture.Release();
        }    

        camera4.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera4material.mainTexture = camera4.targetTexture;

        if (camera5.targetTexture != null)
        {
            camera5.targetTexture.Release();
        }    

        camera5.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera5material.mainTexture = camera5.targetTexture;

        if (camera6.targetTexture != null)
        {
            camera6.targetTexture.Release();
        }    

        camera6.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camera6material.mainTexture = camera6.targetTexture;
    }
}  