using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  구현 목록
 *  
 *  1) 인터페이스 ICharacterHandler를 상속시켜주세요.
 *  
 *  1-2) 상속 후 에러가 나시면 Alt + Enter 키를 통해 추상 클래스 구현해주세요.
 *
 *  2) HitPoint(Vector3 hitPoint) 메소드 기능 추가
 *      - 전역변수 hitPoint 안에 인자값 hitPoint를 넣어주세요.
 *  
 *  3) IsTouch() 메소드 기능 추가
 *      - 전역변수 isTouch의 값을 return 시켜주세요.
 *      
 *  4) Touch() 메소드 기능 추가
 *       - gameObject를 비활성화 시켜주세요.
 *       
 *  5) 하이라키 뷰 
 *      - POPO 오브젝트에 해당 스크립트를 드래그앤 드랍으로 넣어주세요
 *      - BoxCollider를 만들어주세요. (크기 조절까지)
 *      - 태그를 "Untagged" -> "Player"로 바꿔주세요
 */

public class POPO : MonoBehaviour,ICharacterHandler
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
