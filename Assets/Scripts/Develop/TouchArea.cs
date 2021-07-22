using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Develop
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
            //if (IsTouch())
               SpawnPrefab();
            return;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void SpawnPrefab()
        {
            GameObject spawn = Instantiate(touchFxPrefab, spawnStorage);

            spawn.SetActive(true);
            spawn.transform.localPosition = hitPoint;

        }
    }

}
