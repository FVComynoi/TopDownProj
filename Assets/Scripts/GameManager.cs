using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private PlayerBehaviour Player;

    public PlayerBehaviour GetPlayer()
    {
        return Player;
    }
    private void Awake()
    {
        if (Instance == null) Instance = this;

        Player = FindAnyObjectByType<PlayerBehaviour>();

        if (Player == null)
            Debug.LogError("No Player Found");
        else
            Debug.Log("Player Found");
    }

}
