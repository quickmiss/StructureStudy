using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Structure
{
    public class PlayerUnit : PlayerUnitBase
    {

        public override void Start()
        {
            base.Start();
            print("Player!");
        }

        public override void ExecuteMove()
        {
            base.ExecuteMove();
            print("GetMove!");
        }
    }

}

