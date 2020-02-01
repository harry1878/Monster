using System;
using System.Collections.Generic;

using UnityEngine;


class RotateModule : MonoBehaviour
{
    //1. 행성계 구현하기
    //1++. 행성계 곡선으로 구현하기
    //2. isRotate 구현하기

    public float speed = 10;
    [SerializeField] private bool isRotate = true;

    public Transform target = null;
    public Vector3 point = Vector3.zero;
    public Vector3 axis = Vector3.zero;



    private void Update()
    {
        if (isRotate == false) return;

        if (target != null)
        {
            transform.RotateAround(target.localPosition, axis, speed);
            // 나는 해당 축으로 회전한다
            // target의 localPosition 의 위치를 기준으로 
            // axis 에 speed 값을 곱한 값으로 회전한다.
        } 
        else if (point != Vector3.zero)
        {
            transform.RotateAround(point, axis, speed);
        }
        else
        {
            transform.Rotate(axis, speed);
        }
    }
   
    





}


