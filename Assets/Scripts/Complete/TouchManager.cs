using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class TouchManager : MonoBehaviour
    {
        private Ray ray;
        private RaycastHit hit;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0)) // 마우스 좌측 클릭 시 true
            {
                Touch(Input.mousePosition);
            }
        }

        private void Touch(Vector3 mousePosition)
        {
            ray = Camera.main.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    ICharacterHandler character = hit.collider.GetComponent<ICharacterHandler>();

                    character.HitPoint(hit.point);

                    character.Touch();
                }
            }

        }
    }
}


