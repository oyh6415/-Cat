using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDestroy : MonoBehaviour
{
    Animator anim;
    GameObject drop;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        drop = this.gameObject; //몬스터 총알 오브젝트 
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //플레이어의 콜라이더와 부딪히면 총알 터지는 애니 설정
        if (collision.gameObject.tag == "Player")
        {
            PlayerMove.MonsterIndex = index;
            anim.SetTrigger("boom");
        }
        if (collision.gameObject.tag == "Collider")
        {
            anim.SetTrigger("boom");
        }
    }
    void OnDestroy() //boom애니에 클립설정해서 삭제
    {
        Destroy(drop);
    }
}
