using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NewBehaviourScript : MonoBehaviourPunCallbacks
{

    public GameObject player;
    [Space]
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting..");

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster() {
        Debug.Log("Connected to Server!");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("test" ,null ,null);

        Debug.Log("Connected to Room");

    }

    public override void OnJoinedRoom()
    {
        //this syncs the player creation and logic
        GameObject _player = PhotonNetwork.Instantiate(player.name ,spawnPoint.position ,Quaternion.identity);
        //this applies camera and own movement for local only , not all instantiated objects
        _player.GetComponent<PlayerSetup>().IsLocalPlayer();
    }
}
