using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolParameter : MonoBehaviour
{
    //エアコンの時間制御用
    public  float airconTimer = 0;
    public  float airconTimer2 = 0;

    public int constAirconCool = 60;


    Parameter parameter;

    void Start()
    {
        parameter = GameObject.Find("GameSystem").GetComponent<Parameter>();
        airconTimer = parameter.time;
        airconTimer2 = parameter.time;


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
        
        //Debug.Log(Parameter.sceneLoad);

        if(parameter.airconSwitch==1){
             
             if(airconTimer+1<parameter.time){

                if(parameter.airconditioner<parameter.temperature){
                        parameter.temperature -= 0.5f;
                 }else if(parameter.airconditioner>=parameter.temperature){
                        parameter.temperature += 0.5f;
                    }

                airconTimer += 1;
            }

            if(airconTimer2+2<parameter.time){


                if(parameter.temperature>=28){
                    parameter.cool -= 1;
                }else if(parameter.temperature>=25 && parameter.temperature<28 && parameter.cool<=constAirconCool){
                    parameter.cool += 2;
                }else if(parameter.temperature>=23 && parameter.temperature<25 && parameter.cool<=constAirconCool){
                    parameter.cool += 2;
                }else if(parameter.temperature<23){
                    parameter.cool -= 1;
                }

                airconTimer2 += 2;
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
            }

            if(airconTimer2+2<parameter.time){

                if(parameter.temperature>=28){
                 parameter.cool -= 1;
                }else if(parameter.temperature>=25 && parameter.temperature<28 ){
                parameter.cool += 2;
                }else if(parameter.temperature>=23 && parameter.temperature<25 ){
                parameter.cool += 2;
                }else if(parameter.temperature<23){
                parameter.cool -= 1;
                }

            airconTimer2 += 2;

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
            parameter.cool += 40;
        }
    }


}
