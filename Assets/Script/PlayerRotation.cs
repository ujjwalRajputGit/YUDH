using Cinemachine;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] CinemachineFreeLook cinemachineFreeLook;
    [SerializeField] float playerOffSet = 30f;
#pragma warning restore 0649


    private void Start() {
        //Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void FixedUpdate() {
        RotateWithCamera();
    }

    public void RotateWithCamera() {
        float angleY = cinemachineFreeLook.m_XAxis.Value + playerOffSet;
        Vector3 angle = new Vector3(0, 1, 0) * angleY;
        if (transform.eulerAngles.y != angleY) {
            //this.transform.Rotate(angle);
            transform.eulerAngles = angle;
        }
    }
}
