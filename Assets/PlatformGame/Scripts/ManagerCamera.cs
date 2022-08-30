using Cinemachine;
using UnityEngine;

public class ManagerCamera : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] cinemaMachineVirtual;

    private void OnEnable()
    {
        SwitchRotationPlayer.OnCheckCineMachine += CheckCineMachine;
    }

    private void CheckCineMachine(int index)
    {
        for (int i = 0; i < cinemaMachineVirtual.Length; i++)
        {
            cinemaMachineVirtual[i].enabled = false;
        }
        cinemaMachineVirtual[index].enabled = true;
    }

    private void OnDisable()
    {
        SwitchRotationPlayer.OnCheckCineMachine -= CheckCineMachine;
    }
}
