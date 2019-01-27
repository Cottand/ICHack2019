using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class HighlightObject : MonoBehaviour {

  private float animationTime = 1f;
  private float threshold = 1.5f;
  private HighlightController controller;
  private Material material;
  private Color normalColor;
  private Color selectedColor;

  private void Awake() {
    material = GetComponent<MeshRenderer>().material;
    controller = FindObjectOfType<HighlightController>();

    normalColor = material.color;
    selectedColor = new Color(
      Mathf.Clamp01(255),
      Mathf.Clamp01(255),
      Mathf.Clamp01(0)
    );
  }

  public void StartHighlight() {
    iTween.ColorTo(gameObject, iTween.Hash(
      "color", selectedColor,
      "time", animationTime,
      "easetype", iTween.EaseType.linear,
      "looptype", iTween.LoopType.pingPong
    ));
  }

  public void StopHighlight() {
    iTween.Stop(gameObject);
    material.color = normalColor;
  }

  private void OnMouseDown() {
    controller.SelectObject(this);
  }
  
}