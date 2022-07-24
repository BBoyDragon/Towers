using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel 
{
    private GameObject PointOne;
    private GameObject PointTwo;
    private GameObject AttentionPoint;
    private bool isOnPoint=false;

    public EnemyModel(GameObject pointOne,GameObject pointTwo,GameObject attentionPoint )
    {
        PointOne = pointOne;
        PointTwo = pointTwo;
        AttentionPoint = attentionPoint;
    }
    public void Execute()
    {
        if (isOnPoint)
        {
            AttentionPoint.transform.Translate((PointTwo.transform.position-AttentionPoint.transform.position) * Time.deltaTime*0.5f);
            if (Vector2.Distance(AttentionPoint.transform.position, PointTwo.transform.position) <= 1)
            {
                isOnPoint = false;
            }
        }
        else
        {
            AttentionPoint.transform.Translate((PointOne.transform.position-AttentionPoint.transform.position ) * Time.deltaTime*0.5f);
            if (Vector2.Distance(AttentionPoint.transform.position, PointOne.transform.position) <= 1)
            {
                isOnPoint = true;
            }
        }
    }
}
