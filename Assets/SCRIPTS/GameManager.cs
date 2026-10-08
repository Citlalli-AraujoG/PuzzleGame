using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerControls player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.PlayerStart();
    }

    // Update is called once per frame
    void Update()
    {
        player.PlayerUpdate();
    }
}
