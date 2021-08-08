using ExitGames.Client.Photon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Network : MonoBehaviour, IPunCallbacks
{
    [SerializeField] private Lobby lobby; 

    public void OnJoinedRoom()
    {
        if (PhotonNetwork.isMasterClient)
            PhotonNetwork.LoadLevel("Game");
    }

    public void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }

    public void OnConnectedToMaster()
    {
        if(lobby)
            lobby.Log("Connected to Master");
        else
            Debug.Log("Connected to Master");
    }

    public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
    {
    }

    public void OnPhotonCreateRoomFailed(object[] codeAndMsg)
    {
    }

    public void OnPhotonJoinRoomFailed(object[] codeAndMsg)
    {
    }

    public void OnCreatedRoom()
    {
    }

    public void OnJoinedLobby()
    {
    }

    public void OnLeftLobby()
    {
    }

    public void OnFailedToConnectToPhoton(DisconnectCause cause)
    {
        if (lobby)
            lobby.Log("Failed connection");
        else
            Debug.Log("Failed connection");
    }

    public void OnConnectionFail(DisconnectCause cause)
    {
        if (lobby)
            lobby.Log("Failed connection");
        else
            Debug.Log("Failed connection");
    }

    public void OnDisconnectedFromPhoton()
    {
        if (lobby)
            lobby.Log("Disconected");
        else
            Debug.Log("Disconected");
    }

    public void OnPhotonInstantiate(PhotonMessageInfo info)
    {
        
    }

    public void OnReceivedRoomListUpdate()
    {;
    }

    public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
    {
        Debug.LogFormat("Player {0} entered room", newPlayer.NickName);
    }

    public void OnPhotonPlayerDisconnected(PhotonPlayer otherPlayer)
    {
        Debug.LogFormat("Player {0} left room", otherPlayer.NickName);
    }

    public void OnPhotonRandomJoinFailed(object[] codeAndMsg)
    {
        if (lobby)
            lobby.Log("No freedom room");
        else
            Debug.Log("No freedom room");
    }

    public void OnPhotonMaxCccuReached()
    {
    }

    public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
    {
    }

    public void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps)
    {
    }

    public void OnUpdatedFriendList()
    {
    }

    public void OnCustomAuthenticationFailed(string debugMessage)
    {
    }

    public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
    {
    }

    public void OnWebRpcResponse(OperationResponse response)
    {
    }

    public void OnOwnershipRequest(object[] viewAndPlayer)
    {
    }

    public void OnLobbyStatisticsUpdate()
    {
    }

    public void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer)
    {
    }

    public void OnOwnershipTransfered(object[] viewAndPlayers)
    {
    }

    public void OnConnectedToPhoton()
    {
        if (lobby)
            lobby.Log("Connected to Photon");
        else
            Debug.Log("Connected to Photon");
    }
}
