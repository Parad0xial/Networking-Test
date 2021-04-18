using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkConnector : MonoBehaviourPunCallbacks
{
    //instance
    public static NetworkConnector instance;

    void Awake (){
        
        if(instance != null && instance != this)
            gameObject.SetActive(false);
        else {
            //set the instance
        instance = this;
        DontDestroyOnLoad(gameObject);
		}

	}

    void Start(){
        PhotonNetwork.ConnectUsingSettings();
	}

    public override void OnConnectedToMaster(){
        Debug.Log("Connected to master server");
        CreateRoom("testRoom");
	}

    public override void OnCreatedRoom(){
        Debug.Log("Created room: "+ PhotonNetwork.CurrentRoom.Name);
	}

    public void CreateRoom (string roomName){
     PhotonNetwork.CreateRoom(roomName);
	}

    public void JoinRoom (string roomName){
        PhotonNetwork.JoinRoom(roomName);
	}

    public void ChangeScene (string sceneName){
        PhotonNetwork.LoadLevel(sceneName);
	}
}