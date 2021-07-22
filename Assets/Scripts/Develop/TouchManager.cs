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
            /*  구현 기능 목록 
             *  
             *  1) 마우스(좌측)가 눌렸을 때 [ if 조건문 ]
             *      - Touch() 메소드 실행 
             *
             *
             *  ※ 마우스 클릭 조건 확인 참고 - https://wergia.tistory.com/117
             *  
             */

            // 여기 밑에 구현해주세요.
            if (Input.GetKeyDown(KeyCode.Mouse0)) // 마우스 좌측 클릭 시 true
            {
                //Touch(Input.mousePosition);
            }
        }


        private void Touch()
        {
            /* 구현 기능 목록
             *
             *  1) 마우스 클릭 된 지점으로 ray를 쏘기
             *      - 참고 url : https://funfunhanblog.tistory.com/24  
             *      
             *  1-2) 충돌 된 물체의 태그가 "Player" 인지 확인 [ if 조건문 ]
             *  
             *  1-2-1) 해당 코드 삽입
             *  
             *  ICharacterHandler character = hit.collider.GetComponent<ICharacterHandler>();
             *  character.HitPoint(hit.point);
             *  character.Touch();
             *
             *  ※ 1-2-1)의 코드들이 무슨 역활을 하는지 주석을 달아주시면 좋아요.
             *  
             *  추상클래스, 클래스 상속, 인터페이스를 중점으로 구글링 해보시면 좋습니다.
             *  
             *  참고 링크 [인터페이스] - https://luv-n-interest.tistory.com/793 
             *  
             */

            // 여기 밑에 구현해주세요.
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

