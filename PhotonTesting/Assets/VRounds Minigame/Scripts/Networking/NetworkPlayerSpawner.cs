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
        public GameObject playerGameObject;
        public Camera playerCamera;
    }

    [SerializeField]
    private List<NetworkPlayerData> playerDatas = new List<NetworkPlayerData>();

    private int counter;

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        SetPlayer();
    }

    public void SetPlayer()
    {
        NetworkPlayerData networkPlayerData = new NetworkPlayerData();

        spawnablePlayerPrefab = PhotonNetwork.Instantiate("Network Player", transform.position, transform.rotation);

        TestController testController = spawnablePlayerPrefab.GetComponent<TestController>();

        networkPlayerData.name = spawnablePlayerPrefab.name;
        networkPlayerData.playerIndex = counter;
        networkPlayerData.playerGameObject = spawnablePlayerPrefab;
        networkPlayerData.playerCamera = testController.playerCamera;

        playerDatas.Add(networkPlayerData);

        counter++;
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnablePlayerPrefab);
        counter--;
    }
}
