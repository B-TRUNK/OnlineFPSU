using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    //This Script is to overcome multiplayer Sync
    //we need to distinguish local player

    // creating reference for(prefab) player movement and camera
    public PlayerMovement movement;
    public GameObject camera;

    public void IsLocalPlayer(){
        movement.enabled = true;
        camera.SetActive(true);
    }


}
