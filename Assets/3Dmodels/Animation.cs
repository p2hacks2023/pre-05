using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    //-----------------------------------------------------------------------
    // メンバ変数
    //-----------------------------------------------------------------------

    // アニメーター
    private Animator m_Animator = null;

    //-----------------------------------------------------------------------
    // Unityメゾット
    //-----------------------------------------------------------------------

    // 初期化処理
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // 更新処理
    private void Update()
    {
        // 左クリック
        if (Input.GetMouseButtonDown(0))
        {
            if (m_Animator.GetBool("Bool"))
            {
                m_Animator.SetBool("Bool", false);
                // Debug.Log("左クリック");
            }
            else
            {
                m_Animator.SetBool("Bool", true);
                // Debug.Log("左クリック");
            }
        }
    }
}