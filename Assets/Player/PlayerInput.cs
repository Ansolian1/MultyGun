using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PhotonView photonView;
    [SerializeField]
    private Shooting shooting;

    private void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (!photonView.isMine) return;

        if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(-Time.deltaTime * 5, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(Time.deltaTime * 5, 0, 0);

        if (Input.GetMouseButtonDown(0)) shooting.Shoot();
    }
}
