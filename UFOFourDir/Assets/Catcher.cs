using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{
    float _speed = 0.1f;
    Vector3 speed = new Vector3(0, 0, 0);
    Vector3 position = new Vector3(0, 25, 0);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position += speed;
        transform.position = position;
    }

    internal void GetParemeter(string[] strs) {
        string key = null;
        int val = 0;
        for(int i = 0; i < strs.Length; i++) {

            int convertedNum;
            bool canConvert = int.TryParse(strs[i], out convertedNum);
            if(canConvert) {
                val = convertedNum;
            }else {
                if(strs[i].Length <= 1) break;  //なんもなしreturn
                key = strs[i];
            }
        }
        speed = convertData(key, val);
    }

    Vector3 convertData(string key, int val) {
        string right = "right";
        string left = "left";
        string top = "top";
        string bottom = "bottom";

        Vector3 move = speed;
        if(key == right) {
            move.x = val == 1 ? 1 : 0;
        }else if(key == left) {
            move.x = val == 1 ? -1 : 0;
        }
        if(key == top) {
            move.z = val == 1 ? 1 : 0;
        }else if(key == bottom) {
            move.z = val == 1 ? -1 : 0;
        }

        return move;
    }
}