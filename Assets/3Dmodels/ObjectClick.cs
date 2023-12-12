using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectClick : MonoBehaviour, IPointerClickHandler
{
    public Material[] materials; // マテリアルを格納するための配列
    private Renderer renderer;
    private int index = 0;

    void Start()
    {
        // Rendererコンポーネントを取得
        renderer = GetComponent<Renderer>();

        // 初期のマテリアルをセット
        if (materials.Length > 0)
        {
            renderer.material = materials[index];
        }
    }

    // クリックされたときに呼び出されるメソッド
    public void OnPointerClick(PointerEventData eventData)
    {
        // マテリアルを切り替え
        ToggleMaterial();
    }

    // マテリアルを切り替えるメソッド
    private void ToggleMaterial()
    {
        // 次のマテリアルのインデックスを計算
        index = (index + 1) % materials.Length;

        // マテリアルをオブジェクトにセット
        renderer.material = materials[index];
    }
}
