using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.UI;
using ExitGames.Client.Photon;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    [SerializeField] private Text LogText;
    
    void Start()
    {
        PhotonNetwork.playerName = "Player " + Random.Range(1000, 9999);

        PhotonNetwork.automaticallySyncScene = true;
        PhotonNetwork.gameVersion = "1";
        PhotonNetwork.ConnectUsingSettings(PhotonNetwork.gameVersion);

        Log(PhotonNetwork.playerName);
    }

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 2 }, new TypedLobby());
    }

    public void JoinRandomRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public void Log(string message)
    {
        Debug.Log(message);
        if (LogText)
        {
            LogText.text += '\n';
            LogText.text += message;
        }
    }
}
