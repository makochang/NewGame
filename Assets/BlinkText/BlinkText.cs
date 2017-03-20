using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BlinkText : MonoBehaviour
{
    bool canBlink = true;   //点滅できるか.
    Animator animator;       //アニメーターへの参照.

    /// <summary>
    /// 点滅アニメーション終了時(Animation Event)に呼び出す.
    /// </summary>
    void EndBlink()
    {
        canBlink = true;
    }

    // Use this for initialization
    void Start()
    {
        //アニメーターコンポーネントを取得する.
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //何かキーが押されたとき.
        if (Input.anyKeyDown)
        {
            if (canBlink)
            {
                animator.SetTrigger("TriggerBlink");
                canBlink = false;
            }
        }
    }
}
