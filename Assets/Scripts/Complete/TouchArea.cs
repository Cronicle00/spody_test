using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete 
{
    public class TouchArea : MonoBehaviour, ICharacterHandler
    {
        [SerializeField] private Transform spawnStorage;
        [SerializeField] private GameObject touchFxPrefab;

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
            //isTouch = true;

            SpawnPrefab();
        }

        private void SpawnPrefab()
        {
            GameObject spawn = Instantiate(touchFxPrefab, spawnStorage);

            spawn.SetActive(true);
            spawn.transform.localPosition = hitPoint;
        }
    }
}

