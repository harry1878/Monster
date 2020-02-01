using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 컴포넌트화 시키려면 반드시 MonoBehavior 를 상속 받아야함 
public class CubeRotateModule : MonoBehaviour
{
    //기본 접근자
    //    public                       private                         protected
    //  접근 가능?  
    //     O                             X                                 X      
    //  상속 접근가능?
    //     O                             X                                 O 

    // 처음 실행되고 다시는 실행되지 않는 함수
    // 최초 1회 실행되는 함수
    private void Awake()
    {
        Debug.Log("Hello World!");
        // 기본으로 제공하는 정보들
        Debug.Log(name);
        //transform - 해당 오브젝트의 위치정보를 담고 있는 컴포넌트
        //gameObject - 해당 오브젝트 자기 자신(tag, layer 등등 정보를  담고있음)


        //world 좌표, local 좌표
        //world 좌표는 transform.position, rotation, lossyScale
        //transform.position = new Vector3(1, 0, 0);
        //transform.Translate(1, 0, 0);

        // local좌표는 transform.local (접두가 붙는다)


    }

    // 업데이트 들어갈때 마다 angle 값은 0.5f 씩 증가하고
    float anglex = 0;
    float angley = 0;
    float anglez = 0;

    //계속 실행되는 함수
    private void Update()
    {
        //Input.GetKey - 눌러져 있다면 ture를 반환한다
        //Input.GetKeyDown - 눌렀을 때 true를 반환한다
        //Input.GetKeyU - 눌렀다 뗏을때 ture 를 반환한다

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
            //transform.localPosition = new Vector3(-0.1f, 0, 0);
        }

        //Debug.Log("Update");
        //anglex += 0.5f;
        //angley += 0.5f;
        //anglez += 0.5f;

        //transform.localRotation = Quaternion.Euler(anglez, angley, anglex);


    }
    // ctrl shift b 전체 빌드 단축키 
}
