using Photon.Pun;
using Photon.Realtime;
using System;
using UnityEngine;


public class NetWorkManager : MonoBehaviourPunCallbacks
{
    private string version = "1";

    private void Awake()
    {
        PhotonNetwork.GameVersion = version;
    }


    private void Start()
    {
        PhotonNetwork.Disconnect();
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("<color=green> Connect to master Server </color>");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("<color=green> lobby joind </color>");
        UIManager.Instance.HideConnectionPanel();
    }


    public void CreateRoomBu()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        
        PhotonNetwork.CreateRoom("Hiten",roomOptions);
    }

    public void JoinRoonBu()
    {
        PhotonNetwork.JoinRoom("Hiten");
    }

    public override void OnJoinedRoom()
    {
      
        Debug.Log("Player join room");
        PhotonNetwork.LoadLevel("GamePlay");
        
    }
}
