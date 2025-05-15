using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
   public void pause(){
    Time.timeScale = 0;
   }

   public void resume(){
    Time.timeScale = 1;
   }
}
