using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Develop
{
    public class TouchManager : MonoBehaviour
    {
        private Ray ray;
        private RaycastHit hit;

        private void Update()
        {
            /*  ���� ��� ��� 
             *  
             *  1) ���콺(����)�� ������ �� [ if ���ǹ� ]
             *      - Touch() �޼ҵ� ���� 
             *
             *
             *  �� ���콺 Ŭ�� ���� Ȯ�� ���� - https://wergia.tistory.com/117
             *  
             */

            // ���� �ؿ� �������ּ���.
            if (Input.GetKeyDown(KeyCode.Mouse0)) // ���콺 ���� Ŭ�� �� true
            {
                //Touch(Input.mousePosition);
            }
        }


        private void Touch()
        {
            /* ���� ��� ���
             *
             *  1) ���콺 Ŭ�� �� �������� ray�� ���
             *      - ���� url : https://funfunhanblog.tistory.com/24  
             *      
             *  1-2) �浹 �� ��ü�� �±װ� "Player" ���� Ȯ�� [ if ���ǹ� ]
             *  
             *  1-2-1) �ش� �ڵ� ����
             *  
             *  ICharacterHandler character = hit.collider.GetComponent<ICharacterHandler>();
             *  character.HitPoint(hit.point);
             *  character.Touch();
             *
             *  �� 1-2-1)�� �ڵ���� ���� ��Ȱ�� �ϴ��� �ּ��� �޾��ֽø� ���ƿ�.
             *  
             *  �߻�Ŭ����, Ŭ���� ���, �������̽��� �������� ���۸� �غ��ø� �����ϴ�.
             *  
             *  ���� ��ũ [�������̽�] - https://luv-n-interest.tistory.com/793 
             *  
             */

            // ���� �ؿ� �������ּ���.
            //ray = Camera.main.ScreenPointToRay(mousePosition);

            //if (Physics.Raycast(ray, out hit))
            //{
            //    if (hit.collider.CompareTag("Player"))
            //    {
            //        ICharacterHandler character = hit.collider.GetComponent<ICharacterHandler>();

            //        character.HitPoint(hit.point);

            //        character.Touch();
            //    }
            //}
        }
    }
}

