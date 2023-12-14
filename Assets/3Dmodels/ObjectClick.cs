using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectClick : MonoBehaviour, IPointerClickHandler
{
    public Material[] materials; // �}�e���A�����i�[���邽�߂̔z��
    private Renderer renderer;
    private int index = 0;

    void Start()
    {
        // Renderer�R���|�[�l���g���擾
        renderer = GetComponent<Renderer>();

        // �����̃}�e���A�����Z�b�g
        if (materials.Length > 0)
        {
            renderer.material = materials[index];
        }
    }

    // �N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
    public void OnPointerClick(PointerEventData eventData)
    {
        // �}�e���A����؂�ւ�
        ToggleMaterial();
    }

    // �}�e���A����؂�ւ��郁�\�b�h
    private void ToggleMaterial()
    {
        // ���̃}�e���A���̃C���f�b�N�X���v�Z
        index = (index + 1) % materials.Length;

        // �}�e���A�����I�u�W�F�N�g�ɃZ�b�g
        renderer.material = materials[index];
    }
}
