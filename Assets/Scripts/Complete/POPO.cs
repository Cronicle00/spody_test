using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class POPO : MonoBehaviour, ICharacterHandler
    {
        private Vector3 hitPoint;
        private bool isTouch;

        public bool IsTouch()
        {
            return isTouch;
        }

        public void HitPoint(Vector3 hitPoint)
        {
            this.hitPoint = hitPoint;
        }

        public void Touch()
        {
            if (IsTouch()) return;
            isTouch = true;

            gameObject.SetActive(false);
        }
    }
}


