using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public GameObject prefab = null;

    void Start()
    {
        
    }

    
    void Update()
    {
        //0:왼쪽, 1 : right, 2: wheel click
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, worldPosition, Quaternion.identity);
        }

        else if (Input.GetMouseButtonDown(1))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(
                worldPos,
                Vector2.zero);
            if (hit.collider != null && hit.collider.tag == "Monster")
            {
                MonsterModule m = hit.collider.GetComponent<MonsterModule>();
                m.Death();
            }
            
        }
        
    }
}
