using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarodev : HeroUnitBase {
    [SerializeField] private AudioClip _someSound;

    void Start() {
        // Example usage of a static system
        AudioSystem.Instance.PlaySound(_someSound);
    }
    
    public override void ExecuteMove() {
        // Perform tarodev specific animation, do damage, move etc.
        // You'll obviously need to accept the move specifics as an argument to this function. 
        // I go into detail in the Grid Game #2 video

        // 타로데브(Tarodev) 관련 특정 애니메이션을 수행하고, 데미지를 주고, 이동합니다.
        // 이 함수에 이동 관련 세부 정보를 인수로 받아야 할 것입니다.
        // 자세한 내용은 Grid Game #2 영상에서 다룹니다.
        base.ExecuteMove(); // Call this to clean up the move
    }
}
