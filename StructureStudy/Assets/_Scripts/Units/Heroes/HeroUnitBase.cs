using UnityEngine;

public abstract class HeroUnitBase : UnitBase {
    private bool _canMove;

    private void Awake() => ExampleGameManager.OnBeforeStateChanged += OnStateChanged;

    private void OnDestroy() => ExampleGameManager.OnBeforeStateChanged -= OnStateChanged;

    private void OnStateChanged(GameState newState) {
        if (newState == GameState.HeroTurn) _canMove = true;
    }

    private void OnMouseDown() {
        // Only allow interaction when it's the hero turn
        // 히어로 턴에 상호작용이 가능하게 작성합니다. 이는 히어로 유닛 한정이며, 다른 enemy경우는 다른 조건으로 구성해야 합니다.
        if (ExampleGameManager.Instance.State != GameState.HeroTurn) return;

        // Don't move if we've already moved
        // 히어로가 이미 움직임을 가졌다면 고정합니다.
        if (!_canMove) return;

        // Show movement/attack options
        // 공격 또는 이동 선택지 표시

        // Eventually either deselect or ExecuteMove(). You could split ExecuteMove into multiple functions
        // like Move() / Attack() / Dance()

        // 결국 선택을 하지 않거나 ExecutMove를 실행합니다. ExecutMove()를 Move()/ Attack()/ Dance()과 같이 여러 함수로 나뉠 수 있습니다.
        Debug.Log("Unit clicked");
    }

    public virtual void ExecuteMove() {
        // Override this to do some hero-specific logic, then call this base method to clean up the turn
        // 이를 오버라이드하여 히어로에 특화된 로직을 수행한 후, 이 기본 메서드를 호출하여 턴을 정리하세요.
        _canMove = false;
    }
}