using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    private GameObject spawnablePlayerPrefab;

    [System.Serializable]
    public struct NetworkPlayerData
    {
        public string name;
        public int playerIndex;
        public GameObject spawnablePlayerPrefab;
        public Camera playerCamera;
    }

    [SerializeField]
    private List<NetworkPlayerData> playerDatas = new List<NetworkPlayerData>();

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        SetPlayer();
    }

    public void SetPlayer()
    {
        spawnablePlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnablePlayerPrefab);
    }
}
