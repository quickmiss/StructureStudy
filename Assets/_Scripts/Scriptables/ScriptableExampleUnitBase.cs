using System;
using UnityEngine;

/// <summary>
/// Keeping all relevant information about a unit on a scriptable means we can gather and show
/// info on the menu screen, without instantiating the unit prefab.
/// 
/// 유닛에 관한 모든 관련 정보를 스크립터블 오브젝트에 보관하면, 유닛 프리팹을 
/// 인스턴스화하지 않고도 메뉴 화면에서 정보를 수집하고 표시할 수 있습니다.
/// </summary>
public abstract class ScriptableExampleUnitBase : ScriptableObject {
    public Faction Faction;

    [SerializeField] private Stats _stats;
    public Stats BaseStats => _stats;

    // Used in game
    public HeroUnitBase Prefab;
    
    // Used in menus
    public string Description;
    public Sprite MenuSprite;
}

/// <summary>
/// Keeping base stats as a struct on the scriptable keeps it flexible and easily editable.
/// We can pass this struct to the spawned prefab unit and alter them depending on conditions.
/// 
/// 스크립터블 오브젝트에 기본 스탯을 구조체로 유지하는 것은 유연성과 수정 용이성을 제공합니다.
/// 이 구조체를 스폰된 프리팹 유닛에 전달하고 조건에 따라 수정할 수 있습니다.
/// </summary>
[Serializable]
public struct Stats {
    public int Health;
    public int AttackPower;
    public int TravelDistance;
}

[Serializable]
public enum Faction {
    Heroes = 0,
    Enemies = 1
}