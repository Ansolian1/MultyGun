using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    private PhotonView photonView;

    private void Start()
    {
        photonView = GetComponent<PhotonView>();
    }


    void Update()
    {
        if (!photonView.isMine) return;

        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, transform.position.z));
        Vector3 diff = mouseWorld - transform.position;
        diff.Normalize();
        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);
    }
}
