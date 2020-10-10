public interface IPlayerState {
    void Start();
    void Update();
    void FixedUpdate();
    void OnExit();
    bool StateCompleted();

}