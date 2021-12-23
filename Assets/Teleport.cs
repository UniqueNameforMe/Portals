using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform destination;
    public AudioSource sound;

    private bool overlap = false;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (overlap)
        {
            Vector3 portaltoPlayer = player.position - transform.position;
            float dotprod = Vector3.Dot(transform.up, portaltoPlayer);

            if (dotprod >= 0f)
            {   
                Debug.Log("Hi!");
                float rotate_diff = -Quaternion.Angle(transform.rotation, destination.rotation);
                rotate_diff += 180;
                player.Rotate(Vector3.up, rotate_diff);

                Vector3 offset = Quaternion.Euler(0, rotate_diff, 0) * portaltoPlayer;
                player.position = destination.position + offset;

                overlap = false;
            }
        }
    }


    void OnTriggerEnter (Collider obj)
    {
            overlap = true;
            sound.Play();
    }

    void OnTriggerExit(Collider obj)
    {
        overlap = false;
    }
}
