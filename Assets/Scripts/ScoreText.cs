using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreText : MonoBehaviour {
    [SerializeField] private bool hideOutOfGame = true;
    private Text text;
    private GameManager manager;

    private void Awake() {
        text = GetComponent<Text>();
        manager = FindObjectOfType<GameManager>();
    }

    private void Update() {
        if (hideOutOfGame)
            transform.parent.GetComponent<Image>().enabled = manager.IsPlaying;
        if (hideOutOfGame)
            text.enabled = manager.IsPlaying;

        text.text = $"-{manager.Score}m";
    }
}
