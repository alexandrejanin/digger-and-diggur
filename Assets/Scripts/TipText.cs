using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TipText : MonoBehaviour {
    private Text text;
    private GameManager manager;

    private void Awake() {
        text = GetComponent<Text>();
        manager = FindObjectOfType<GameManager>();
    }

    private void Update() {
        text.enabled = manager.IsPlaying;
        text.text = manager.Minigame
            ? manager.Minigame.Description
            : "Dig one at a time!";
    }
}
