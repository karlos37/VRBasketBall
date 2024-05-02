using UnityEngine;
using TMPro;

public class CountBaskets : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Add the GameObject which has TextMeshPro component of the score here")]
    private GameObject score;
    
    private int _initialScore;

    private TextMeshPro _textMeshPro;
    private void Start()
    {
        var found = score.TryGetComponent(out _textMeshPro);
        print(found ? "Found text " : "Did not find textMeshPro");
    }
    public void IncreaseScore()
    {
        _initialScore++;
        if (_textMeshPro != null)
        {
            _textMeshPro.text = _initialScore.ToString();
        }
    }
}
