using UnityEngine;

public class PlayerStateMachine : MonoBehaviour {
    private IPlayerState currentPlayerState;
    private IPlayerState previousPlayerState;

    public void ChangePlayerState(IPlayerState newPlayerState) {
        if (currentPlayerState != null) {
            currentPlayerState.OnExit();
            previousPlayerState = currentPlayerState;
        }
        currentPlayerState = newPlayerState;
        currentPlayerState.Start();
    }

    private void Update() {
        if (currentPlayerState != null) {
            currentPlayerState.Update();
            Debug.Log(currentPlayerState);
        }
    }

    private void FixedUpdate() {
        if (currentPlayerState != null)
            currentPlayerState.FixedUpdate();
    }

    public void SwitchToPreviousPlayerState() {
        if (currentPlayerState != null) {
            currentPlayerState.OnExit();
            currentPlayerState = previousPlayerState;
            currentPlayerState.Start();
        }
    }

    public bool OnCurrentStateComplete() {
        return currentPlayerState.StateCompleted();
    }
}