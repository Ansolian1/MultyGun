using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerPrefab;

    private void Start()
    {
        GameObject player = PhotonNetwork.Instantiate(PlayerPrefab.name, new Vector3(1, Random.Range(-2.0f, 2.0f), 1), Quaternion.identity, 0);
        player.tag = "Player";
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }
}
