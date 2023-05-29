using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{


    [SerializeField]
    Vector2Int boardSize = new Vector2Int(11, 11);

    [SerializeField]
    Vector2Int minBoardSize = new Vector2Int(2, 2);

    [SerializeField]
    GameBoard board = default;


    void Awake()
    {
        OnValidate();
        board.Initialize(boardSize);
    }

    private void OnValidate()
    {
        if (boardSize.x < minBoardSize.x) boardSize.x = minBoardSize.x;
        if (boardSize.y < minBoardSize.y) boardSize.y = minBoardSize.y;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
