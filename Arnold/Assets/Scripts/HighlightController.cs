using UnityEngine;

public class HighlightController : MonoBehaviour {

  private HighlightObject highlightObject;
  public TrackGameObject labelPanel;

  private void Start() {
    labelPanel.gameObject.SetActive(false);
  }

  public void SelectObject(HighlightObject highlightObject) {
    if (this.highlightObject == highlightObject) {
      this.highlightObject.StopHighlight();
      labelPanel.gameObject.SetActive(false);
      this.highlightObject = null;
    } else {
        labelPanel.gameObject.SetActive(true);
        if (this.highlightObject != null) {
          this.highlightObject.StopHighlight();
        }

        this.highlightObject = highlightObject;
        labelPanel.textbox.text = this.highlightObject.name;
        this.highlightObject.StartHighlight();
        labelPanel.TrackObject = highlightObject.gameObject;
    }
  }

}