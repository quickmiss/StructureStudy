using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Structure
{
    public class UnitBase : MonoBehaviour
    {
        public Stats Stats { get; private set; }
        public virtual void SetStats(Stats stats) => Stats = stats;

        public virtual void TakeDamage(float dmg)
        {

        }
    }

    [Serializable]
    public struct Stats
    {
        public float Health;
        public float DefencePower;
        public float AttackPower;
        public float AttackRange;

        public float MoveSpeed;

    }

}

