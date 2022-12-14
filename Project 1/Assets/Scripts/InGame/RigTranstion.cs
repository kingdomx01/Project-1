using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using StarterAssets;
using Photon.Pun;

public class RigTranstion : MonoBehaviour
{
    [SerializeField] private RigBuilder _rigBuilder;

    private StarterAssetsInputs _input;
    private PhotonView pv;
    public enum StateCharacter 
    { 
        nothing,
        hasGunRun,
        hasGunShoot,
    }
    [SerializeField] public StateCharacter _stateCharacter; // Set Null
    private void Start()
    {
        pv = GetComponent<PhotonView>();
        _rigBuilder = GetComponent<RigBuilder>();
        _input = GetComponent<StarterAssetsInputs>();
        Cursor.lockState = CursorLockMode.None;
    }
    // Update is called once per frame
    void Update()
    {
        if (!pv.IsMine) return;
        if (Input.GetMouseButton(1) || Input.GetMouseButton(0))
        {
            _stateCharacter = StateCharacter.hasGunShoot;
        }
        else
        {  
            _stateCharacter = StateCharacter.hasGunRun;
        }
    }
}
