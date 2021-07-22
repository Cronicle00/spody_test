using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterHandler
{
    bool IsTouch();

    void HitPoint(Vector3 hitPoint);

    void Touch();
}
