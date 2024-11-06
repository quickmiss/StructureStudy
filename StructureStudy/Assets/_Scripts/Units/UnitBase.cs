using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This will share logic for any unit on the field. Could be friend or foe, controlled or not.
/// Things like taking damage, dying, animation triggers etc
/// 이 코드는 필드에 있는 모든 유닛에 대한 논리를 공유할 것입니다. 아군이든 적군이든, 조작 가능한 유닛이든 아니든 모두 해당됩니다.
/// 데미지 받기, 사망, 애니메이션 트리거 같은 것들이 포함됩니다.
/// </summary>
public class UnitBase : MonoBehaviour {
    public Stats Stats { get; private set; }
    public virtual void SetStats(Stats stats) => Stats = stats;

    public virtual void TakeDamage(int dmg) {
        
    }
}