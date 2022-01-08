using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public string roomName = "Room";

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Server Connection Successful.");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Joined Lobby Successful.");
        PhotonNetwork.JoinOrCreateRoom(roomName, null, null);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        GetComponent<NetworkPlayerSpawner>().SpawnPlayer();
        Debug.Log("Conection and Joined Room Successful.");
    }
}
