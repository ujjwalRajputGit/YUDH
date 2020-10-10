using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] InputReader inputReader;

    [SerializeField] CinemachineFreeLook cinemachineFreeLook;
#pragma warning restore 0649

    void OnCameraMove(Vector2 cameraMovement) {
        //cinemachineFreeLook.m_XAxis.m_InputAxisValue = cameraMovement.x * Time.smoothDeltaTime;
        //cinemachineFreeLook.m_YAxis.m_InputAxisValue = cameraMovement.y * Time.smoothDeltaTime;
    }


    private void OnEnable() {
        inputReader.rotateCameraEvent += OnCameraMove;
    }

    private void OnDisable() {
        inputReader.rotateCameraEvent -= OnCameraMove;
    }
}
