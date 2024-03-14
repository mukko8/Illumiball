using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Hole : MonoBehaviour
{
    //どのボールを吸い寄せるかをタグで指定
    public string targetTag;
    bool isHolding;
    //ボールが入っているか返す
    public bool IsHolding(){
        return isHolding;
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag==targetTag){
            isHolding=true;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag==targetTag){
            isHolding=false;
        }
    }
    void OnTriggerStay(Collider other){
        //コライダに触れているオブジェクトのRigidbodyコンポーネントを取得
        Rigidbody r=other.gameObject.GetComponent<Rigidbody>();
        //ボールがどの方向にあるかを計算
        Vector3 direction=other.gameObject.transform.position-transform.position;
        direction.Normalize();
        //タグに応じてボールに力を加える
        if(other.gameObject.tag==targetTag){
            //中心地点でボールを止めるために速度を減速させる
            r.velocity*=0.9f;
            r.AddForce(direction*-20.0f,ForceMode.Acceleration);
        }else{
            r.AddForce(direction * 80f,ForceMode.Acceleration);
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
