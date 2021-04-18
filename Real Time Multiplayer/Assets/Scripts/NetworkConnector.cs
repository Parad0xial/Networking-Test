using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkConnector : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    #region Pun Callbacks

    public override void OnConnectedToMaster()
    {
        // Try to join a random room
        PhotonNetwork.JoinRandomRoom();
    }



    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        // Failed to connect to random, probably because none exist
        Debug.Log(message);

        // Create a new room to join instead
        PhotonNetwork.CreateRoom("My First Room");
    }

    public override void OnJoinedRoom()
    {
        Debug.Log($"{PhotonNetwork.CurrentRoom.Name} joined!");
    }

    #endregion
}

