using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Structure
{
    public abstract class PlayerUnitBase : UnitBase
    {
        [SerializeField]private Rigidbody rig;
        private bool _isTouch;

        private void Awake()
        {

        }
        public virtual void Start()
        {
            if (rig == null) rig = GetComponent<Rigidbody>();
            _isTouch = false;
        }
        private void OnDestroy()
        {

        }
        public virtual void FixedUpdate()
        {
            TouchMove();
        }
        private void OnStateChange()
        {

        }

        private void OnMouseDown()
        {
            _isTouch = !_isTouch;
            ExecuteMove();
        }
        public virtual void ExecuteMove()
        {

        }
        public virtual void TouchMove()
        {
            if (!_isTouch) return;
            rig.MovePosition(transform.position + Vector3.left * Time.fixedDeltaTime * 10f);
        }

    }

}
