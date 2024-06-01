using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private ScoreManager _scoreManager;

    private static UiManager instance;
    public static UiManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }

    }


    public void UpdateScore()
    {
        _scoreManager.UpdateScore();
    }
}
