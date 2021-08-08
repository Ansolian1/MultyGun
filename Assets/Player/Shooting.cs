using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;

    public void Shoot()
    {
        PhotonNetwork.Instantiate(BulletPrefab.name, transform.position, transform.rotation, 0);
    }
}
