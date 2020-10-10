using UnityEngine;

public class Input : MonoBehaviour {

#pragma warning disable 0649
    [SerializeField] InputReader inputReader;
#pragma warning restore 0649

    static Vector3 getAxis;
    static bool isControlsEnabled = true;
    static bool isLeftShiftDown;
    static bool jumpKeyPressed;
    static bool crouchKeyPressed;

    public static Vector3 GetAxis { get { return (isControlsEnabled) ? getAxis : new Vector3(0, 0, 0); } }
    public static bool IsControlsEnabled { get => isControlsEnabled; set => isControlsEnabled = value; }
    public static bool IsLeftShiftDown { get { return (isControlsEnabled) ? isLeftShiftDown : false; } }
    public static bool JumpKeyPressed { get { return (isControlsEnabled) ? jumpKeyPressed : false;} set { if(isControlsEnabled) { jumpKeyPressed = value;}}}
    public static bool CrouchKeyPressed { get { return (isControlsEnabled) ? crouchKeyPressed : false; }}

    void LeftShiftDown(float value) {
        if (value > 0.5f) {
            isLeftShiftDown = true; //true when pressed, return 1 when presed, for safety we use > .5
        } else {
            isLeftShiftDown = false; // false when released, when release return 0
        }
    }

    void JumpKey() {
        JumpKeyPressed = true; // should be false when work is done
    }
    void Move(Vector2 move) { //method called by unityEvent.
        getAxis = new Vector3(move.x, 0, move.y);
    }

    void CrouchKey() {
        crouchKeyPressed = !crouchKeyPressed;
    }

    void OnEnable() { //adding ethod to unityEvent.
        inputReader.moveEvent += Move;
        inputReader.sprintEvent += LeftShiftDown;
        inputReader.jumpEvent += JumpKey;
        inputReader.crouchEvent += CrouchKey;
    }
    void OnDisable() { //removing method from unityEvent.
        inputReader.moveEvent -= Move;
        inputReader.sprintEvent -= LeftShiftDown;
        inputReader.crouchEvent -= CrouchKey;
    }
}
