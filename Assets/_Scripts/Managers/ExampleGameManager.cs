using System;
using UnityEngine;

/// <summary>
/// Nice, easy to understand enum-based game manager. For larger and more complex games, look into
/// state machines. But this will serve just fine for most games.
/// 
/// 멋지고 이해하기 쉬운 열거형 기반 게임 매니저입니다. 더 크고 복잡한 게임의 경우, 상태 머신을 고려해 보세요. 
/// 하지만 대부분의 게임에는 이 방법으로 충분히 잘 작동할 것입니다.
/// </summary>
public class ExampleGameManager : StaticInstance<ExampleGameManager> {
    public static event Action<GameState> OnBeforeStateChanged; // 상태 변화 전 구독자 호출을 하여 사전 처리
    public static event Action<GameState> OnAfterStateChanged;

    public GameState State { get; private set; }

    // Kick the game off with the first state
    void Start() => ChangeState(GameState.Starting);

    public void ChangeState(GameState newState) {
        OnBeforeStateChanged?.Invoke(newState);

        State = newState;
        switch (newState) {
            case GameState.Starting:
                HandleStarting();
                break;
            case GameState.SpawningHeroes:
                HandleSpawningHeroes();
                break;
            case GameState.SpawningEnemies:
                HandleSpawningEnemies();
                break;
            case GameState.HeroTurn:
                HandleHeroTurn();
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.Win:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

        OnAfterStateChanged?.Invoke(newState);
        
        Debug.Log($"New state: {newState}");
    }

    private void HandleStarting() {
        // Do some start setup, could be environment, cinematics etc
        // 초기 설정 작업 수행, 환경 설정, 시네마틱 등일 수 있습니다.

        // Eventually call ChangeState again with your next state
        // 결국 다음 상태로 ChangeState를 다시 호출하세요

        ChangeState(GameState.SpawningHeroes);
    }

    private void HandleSpawningHeroes() {
        ExampleUnitManager.Instance.SpawnHeroes();
        
        ChangeState(GameState.SpawningEnemies);
    }

    private void HandleSpawningEnemies() {
        
        // Spawn enemies
        
        ChangeState(GameState.HeroTurn);
    }

    private void HandleHeroTurn() {
        // If you're making a turn based game, this could show the turn menu, highlight available units etc
        
        // Keep track of how many units need to make a move, once they've all finished, change the state. This could
        // be monitored in the unit manager or the units themselves.
    }
}

/// <summary>
/// This is obviously an example and I have no idea what kind of game you're making.
/// You can use a similar manager for controlling your menu states or dynamic-cinematics, etc
/// 
/// 이것은 분명히 하나의 예제이며, 여러분이 어떤 종류의 게임을 만드는지에 대해서는 알 수 없습니다. 
/// 비슷한 매니저를 사용해서 메뉴 상태를 제어하거나 동적 시네마틱 등을 관리할 수 있습니다.
/// </summary>
[Serializable]
public enum GameState {
    Starting = 0,
    SpawningHeroes = 1,
    SpawningEnemies = 2,
    HeroTurn = 3,
    EnemyTurn = 4,
    Win = 5,
    Lose = 6,
}