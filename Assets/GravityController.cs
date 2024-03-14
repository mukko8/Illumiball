using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    //重力加速度
    const float Gravity=9.81f;
    [SerializeField]
    //重力の適応具合
    float gravityScale=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector=new Vector3();
        //キーの入力を検知しベクトルを設定
        vector.x=Input.GetAxis("Horizontal");
        vector.z=Input.GetAxis("Vertical");
        //高さ方向の判定はキーのzとする
        if(Input.GetKey("z")){
            vector.y=1.0f;
        }else{
            vector.y=-1.0f;
        }
        //シーンの重力を入力ベクトルの方向に合わせて変化させる
        Physics.gravity=Gravity*vector.normalized*gravityScale;
    }
}
