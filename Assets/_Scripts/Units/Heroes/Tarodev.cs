using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarodev : HeroUnitBase {
    [SerializeField] private AudioClip _someSound;

    void Start() {
        // Example usage of a static system
        // ���÷� Audio�� ���� �ý����� ����߽��ϴ�.
        AudioSystem.Instance.PlaySound(_someSound);
    }
    
    public override void ExecuteMove() {
        // Perform tarodev specific animation, do damage, move etc.
        // You'll obviously need to accept the move specifics as an argument to this function. 
        // I go into detail in the Grid Game #2 video

        // Ÿ�ε���(Tarodev) ���� Ư�� �ִϸ��̼��� �����ϰ�, �������� �ְ�, �̵��մϴ�.
        // �� �Լ��� �̵� ���� ���� ������ �μ��� �޾ƾ� �� ���Դϴ�.
        // �ڼ��� ������ Grid Game #2 ���󿡼� �ٷ�ϴ�. ( URL : https://www.youtube.com/watch?v=tE1qH8OxO2Y )
        base.ExecuteMove(); // Call this to clean up the move
    }
}
