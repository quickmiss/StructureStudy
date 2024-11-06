using UnityEngine;

/// <summary>
/// An example of a scene-specific manager grabbing resources from the resource system
/// Scene-specific managers are things like grid managers, unit managers, environment managers etc
/// 리소스 시스템에서 리소스를 가져오는 씬별 매니저의 예제입니다. 
/// 씬별 매니저는 그리드 매니저, 유닛 매니저, 환경 매니저와 같은 것들을 의미합니다.
/// </summary>
public class ExampleUnitManager : StaticInstance<ExampleUnitManager> {

    public void SpawnHeroes() {
        SpawnUnit(ExampleHeroType.Tarodev, new Vector3(1, 0, 0));
    }

    void SpawnUnit(ExampleHeroType t, Vector3 pos) {
        var tarodevScriptable = ResourceSystem.Instance.GetExampleHero(t);

        var spawned = Instantiate(tarodevScriptable.Prefab, pos, Quaternion.identity,transform);

        // Apply possible modifications here such as potion boosts, team synergies, etc
        // 포션 부스트나 팀 시너지와 같은 가능한 수정 사항들을 여기에 적용하세요.
        var stats = tarodevScriptable.BaseStats;
        stats.Health += 20;

        spawned.SetStats(stats);
    }
}