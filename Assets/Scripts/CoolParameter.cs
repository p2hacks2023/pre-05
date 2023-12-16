using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolParameter : MonoBehaviour
{
    //エアコンの時間制御用
    public float airconTimer = 0;



    Parameter parameter;

    void Start()
    {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
        if(Parameter.sceneLoad<1) {
            parameter.temperature = 32;
            parameter.airconditioner = 25;
            parameter.cool = 30;

        }
        else parameter.temperature =PlayerPrefs.GetFloat("temperatureSaved");


    }

/*ひんやり度仕様
エアコンoff->温度が上昇(max35)
エアコンon->
            //・エアコンの設定温度=室内温度
・室内デフォ32度
・設定温度が28以上->ひんやり度down
・設定温度が22以下->ひんやり度donn(下がる)

*/


   

    void Update()
    {
        
        if(parameter.airconSwitch==1){
             
             if(airconTimer+1<parameter.time){

                if(parameter.airconditioner>=21 && parameter.airconditioner<24){
                    parameter.temperature -= 0.5f;
                 }else if(parameter.airconditioner>=24 && parameter.airconditioner<28){
                    parameter.temperature -= 0.3f;
                 }else if(parameter.airconditioner>=28){
                    //parameter.temperature -= 0;
                }   

                if(parameter.temperature>=28){
                    parameter.cool -= 1;
                }else if(parameter.temperature>=25 && parameter.temperature<28){
                    parameter.cool += 2;
                }else if(parameter.temperature>=23 && parameter.temperature<25){
                    parameter.cool += 2;
                }else if(parameter.temperature<23){
                    parameter.cool -= 1;
                }

                if(parameter.temperature<19){
                parameter.temperature=19;
                }

                airconTimer += 1;
            }

        }else{
         if(airconTimer+1<parameter.time){
            parameter.temperature +=0.2f;
            if(parameter.temperature>33){
                parameter.temperature=33;
            }
            if(parameter.temperature>=28){
                    parameter.cool -= 1;
                }
            airconTimer += 1;


            if(parameter.temperature>=28){
                 parameter.cool -= 1;
            }else if(parameter.temperature>=25 && parameter.temperature<28){
                parameter.cool += 2;
            }else if(parameter.temperature>=23 && parameter.temperature<25){
                parameter.cool += 2;
            }else if(parameter.temperature<23){
                parameter.cool -= 1;
            }



            }
        }

            if(parameter.cool>100){
                parameter.cool = 100;
            }else if(parameter.cool<0){
                parameter.cool = 0;
            }


    }

    public void eatWatermelon(){
        if(Parameter.watermelon>=1){
            Parameter.watermelon -= 1;
            parameter.cool += 20;
        }
    }


}
