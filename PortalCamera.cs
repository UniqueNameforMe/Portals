using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform playerCamera;
    public Transform cameraportal;
    public Transform playerportal;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerportaldiff = playerCamera.position - playerportal.position;
        transform.position = cameraportal.position + playerportaldiff;

        float rotational_diff = Quaternion.Angle(cameraportal.rotation, playerportal.rotation);

        Quaternion portalrotational_diff = Quaternion.AngleAxis(rotational_diff, Vector3.up);
        Vector3 updatedcamera = portalrotational_diff * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(updatedcamera, Vector3.up);
    }
}
