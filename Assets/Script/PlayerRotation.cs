using Cinemachine;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField]private CinemachineFreeLook cinemachineFreeLook;
    [SerializeField] private float playerOffSet = 30f;

    private void Start() {
        Cursor.visible = false;
    }
    private void FixedUpdate() {
        RotateWithCamera();
    }

    void RotateWithCamera() {
        float angleY = cinemachineFreeLook.m_XAxis.Value + playerOffSet;
        Vector3 angle = new Vector3(0, 1, 0) * angleY;
        if (transform.eulerAngles.y != angleY) {
            //this.transform.Rotate(angle);
            transform.eulerAngles = angle;
        }
    }
}
