using Mirror;
using UnityEngine;

public class CameraScript : NetworkBehaviour
{
    public Camera AircraftCamera;

    void Start()
    {
        if (isLocalPlayer) return;

        AircraftCamera.enabled = false;
    }
}