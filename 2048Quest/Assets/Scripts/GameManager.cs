using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour{
    [SerializeField] private int _width = 4;
    [SerializeField] private int _height = 4;
    [SerializeField] private Node _nodePrefab;
    [SerializeField] private SpriteRenderer _boardPrefab;

    private List<Node> _nodes;


    // Start is called before the first frame update
    void Start(){
        GenerateGrid();
    }

    //initialize Board + Node
    void GenerateGrid(){
        //Node grid Setting
        _nodes = new List<Node>();
        for (int x = 0; x < _width; x++) {
            for (int y = 0; y < _height; y++) {
                var node = Instantiate(_nodePrefab, new Vector2(x, y), Quaternion.identity);
                _nodes.Add(node);
            }
        }
        //Board Setting
        var center = new Vector2((float) _width /2 - 0.5f,(float) _height / 2 -0.5f);
        var board = Instantiate(_boardPrefab, center, Quaternion.identity);
        board.size = new Vector2(_width,_height);

        //Camera Setting
        Camera.main.transform.position = new Vector3(center.x,center.y,-10);
    }

    // Update is called once per frame
    void Update(){
    }
}
