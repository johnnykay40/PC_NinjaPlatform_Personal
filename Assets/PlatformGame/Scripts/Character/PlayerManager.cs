using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager playerManager;
    public enum StatePlayer { idle, swim, running, shooting, hang, dash, jump}
    public StatePlayer statePlayer;

    private void Awake()
    {
        playerManager = this;
    }
}
