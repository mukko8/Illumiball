using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearDetector : MonoBehaviour
{
    public Hole holeRed;
    public Hole holeBlue;
    public Hole holeGreen;
    
    void OnGUI(){
        //すべてのボールが入ったらラベルを表示
        if(holeRed.IsHolding()&&holeBlue.IsHolding()&&holeGreen.IsHolding()){
            GUI.Label(new Rect(50,50,100,30),"Game Clear!");
        }
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
