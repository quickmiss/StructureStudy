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
        // ����� �Ͽ� ��ȣ�ۿ��� �����ϰ� �ۼ��մϴ�. �̴� ����� ���� �����̸�, �ٸ� enemy���� �ٸ� �������� �����ؾ� �մϴ�.
        if (ExampleGameManager.Instance.State != GameState.HeroTurn) return;

        // Don't move if we've already moved
        // ����ΰ� �̹� �������� �����ٸ� �����մϴ�.
        if (!_canMove) return;

        // Show movement/attack options
        // ���� �Ǵ� �̵� ������ ǥ��

        // Eventually either deselect or ExecuteMove(). You could split ExecuteMove into multiple functions
        // like Move() / Attack() / Dance()

        // �ᱹ ������ ���� �ʰų� ExecutMove�� �����մϴ�. ExecutMove()�� Move()/ Attack()/ Dance()�� ���� ���� �Լ��� ���� �� �ֽ��ϴ�.
        Debug.Log("Unit clicked");
    }

    public virtual void ExecuteMove() {
        // Override this to do some hero-specific logic, then call this base method to clean up the turn
        // �̸� �������̵��Ͽ� ����ο� Ưȭ�� ������ ������ ��, �� �⺻ �޼��带 ȣ���Ͽ� ���� �����ϼ���.
        _canMove = false;
    }
}