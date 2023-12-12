using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    //-----------------------------------------------------------------------
    // �����o�ϐ�
    //-----------------------------------------------------------------------

    // �A�j���[�^�[
    private Animator m_Animator = null;

    //-----------------------------------------------------------------------
    // Unity���]�b�g
    //-----------------------------------------------------------------------

    // ����������
    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // �X�V����
    private void Update()
    {
        // ���N���b�N
        if (Input.GetMouseButtonDown(0))
        {
            if (m_Animator.GetBool("Bool"))
            {
                m_Animator.SetBool("Bool", false);
                // Debug.Log("���N���b�N");
            }
            else
            {
                m_Animator.SetBool("Bool", true);
                // Debug.Log("���N���b�N");
            }
        }
    }
}