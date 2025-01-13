using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCharetor : CharectorBase
{


    public override void Init()
    {

    }
    public override void Hit(HitType hitType)
    {
        switch (hitType)
        {
            case HitType.Flower:
                GamePlaycontroller.instance.ChangeCharector(CharectorType.Special);
                break;
            case HitType.RedMusrom:
                GamePlaycontroller.instance.ChangeCharector(CharectorType.Big);
                break;
        }
    }
}
