using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  ���� ���
 *  
 *  1) �������̽� ICharacterHandler�� ��ӽ����ּ���.
 *  
 *  1-2) ��� �� ������ ���ø� Alt + Enter Ű�� ���� �߻� Ŭ���� �������ּ���.
 *
 *  2) HitPoint(Vector3 hitPoint) �޼ҵ� ��� �߰�
 *      - �������� hitPoint �ȿ� ���ڰ� hitPoint�� �־��ּ���.
 *  
 *  3) IsTouch() �޼ҵ� ��� �߰�
 *      - �������� isTouch�� ���� return �����ּ���.
 *      
 *  4) Touch() �޼ҵ� ��� �߰�
 *       - gameObject�� ��Ȱ��ȭ �����ּ���.
 *       
 *  5) ���̶�Ű �� 
 *      - POPO ������Ʈ�� �ش� ��ũ��Ʈ�� �巡�׾� ������� �־��ּ���
 *      - BoxCollider�� ������ּ���. (ũ�� ��������)
 *      - �±׸� "Untagged" -> "Player"�� �ٲ��ּ���
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
