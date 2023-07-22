using UnityEngine;

public class TestScript : MonoBehaviour
{
    public InputReader inputReader;

    void Start()
    {
        inputReader.MoveCamEvent += HandleCamMove;
        inputReader.BuildEvent += HandleBuilding;
    }

    void OnDestroy()
    {
        inputReader.MoveCamEvent -= HandleCamMove;
        inputReader.BuildEvent -= HandleBuilding;
    }

    void HandleCamMove(Vector2 movement)
    {
        Debug.Log(movement);
    }

    void HandleBuilding()
    {
        Debug.Log("Handling buidling");
    }
}
