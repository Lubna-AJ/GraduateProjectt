using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {



    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    

	// Use this for initialization
	void Start () {

        timerBar = GetComponent<Image>();
        timeLeft = maxTime;

	}
	
	// Update is called once per frame
	void Update () {


        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }

        else
        {







            //////////////////////////////////////////Janabi////////////////////////////////////////////

            if (Application.loadedLevelName.Equals("InstaJ1"))
            {

                Application.LoadLevel("JanabiOne");
            }

            else if (Application.loadedLevelName.Equals("JanabiOne"))
            {
                Application.LoadLevel("loseJ1");

            }
            else if (Application.loadedLevelName.Equals("loseJ1"))
            {

                Application.LoadLevel("InstaJ2");
            }
            else if (Application.loadedLevelName.Equals("winJ1"))
            {

                Application.LoadLevel("InstaJ2");
            }
            else if (Application.loadedLevelName.Equals("InstaJ2"))
            {

                Application.LoadLevel("JanabiTwo");
            }
            else if (Application.loadedLevelName.Equals("JanabiTwo"))
            {
                Application.LoadLevel("loseJ2");
                //  Application.LoadLevel("InstaJ3");

            }

            else if (Application.loadedLevelName.Equals("loseJ2"))
            {

                Application.LoadLevel("InstaJ3");

            }
            else if (Application.loadedLevelName.Equals("winJ2"))
            {

                Application.LoadLevel("InstaJ3");

            }
            else if (Application.loadedLevelName.Equals("InstaJ3"))
            {

                Application.LoadLevel("JanabiThree");

            }
            else if (Application.loadedLevelName.Equals("JanabiThree"))
            {
                Application.LoadLevel("loseJ3");
                //  Application.LoadLevel("InstaJ6");

            }
            else if (Application.loadedLevelName.Equals("loseJ3"))
            {

                Application.LoadLevel("InstaJ6");

            }
            else if (Application.loadedLevelName.Equals("winJ3"))
            {

                Application.LoadLevel("InstaJ6");

            }
            else if (Application.loadedLevelName.Equals("InstaJ6"))
            {

                Application.LoadLevel("JanabiSix");

            }
            else if (Application.loadedLevelName.Equals("JanabiSix"))
            {
                Application.LoadLevel("winJ6");
                //   Application.LoadLevel("InstaJ9");

            }
            else if (Application.loadedLevelName.Equals("winJ6"))
            {

                Application.LoadLevel("InstaJ9");

            }
            else if (Application.loadedLevelName.Equals("loseJ6"))
            {

                Application.LoadLevel("InstaJ9");

            }
            else if (Application.loadedLevelName.Equals("InstaJ9"))
            {

                Application.LoadLevel("JanabiNine");

            }
            else if (Application.loadedLevelName.Equals("JanabiNine"))
            {
                Application.LoadLevel("loseJ9");
                // Application.LoadLevel("InstaJ10");

            }
            else if (Application.loadedLevelName.Equals("winJ9"))
            {

                Application.LoadLevel("InstaJ10");

            }

            else if (Application.loadedLevelName.Equals("loseJ9"))
            {

                Application.LoadLevel("InstaJ10");

            }
            else if (Application.loadedLevelName.Equals("InstaJ10"))
            {

                Application.LoadLevel("JanabiTen");

            }
            else if (Application.loadedLevelName.Equals("JanabiTen"))
            {
                Application.LoadLevel("winJ10");
                // Application.LoadLevel("InstaJ11");

            }
            else if (Application.loadedLevelName.Equals("winJ10"))
            {

                Application.LoadLevel("InstaJ11");

            }

            else if (Application.loadedLevelName.Equals("loseJ10"))
            {

                Application.LoadLevel("InstaJ11");

            }
            else if (Application.loadedLevelName.Equals("InstaJ11"))
            {

                Application.LoadLevel("JanabiEleven");

            }
            else if (Application.loadedLevelName.Equals("JanabiEleven"))
            {
               // Application.LoadLevel("winJ11");
                Application.LoadLevel("loseJ11");

               // Application.LoadLevel("loseJ11");
                

            }
            else if (Application.loadedLevelName.Equals("winJ11"))
            {

                Application.LoadLevel("LevelMap");

            }
            else if (Application.loadedLevelName.Equals("loseJ11"))
            {

                Application.LoadLevel("LevelMap");

            }









//////////////////////////////////////////Mada3a////////////////////////////////////////////


            else if (Application.loadedLevelName.Equals("InstaMd1"))
            {

                Application.LoadLevel("mada3aOne");
            }

            else if (Application.loadedLevelName.Equals("mada3aOne"))
            {
                Application.LoadLevel("loseMD1");
                // Application.LoadLevel("InstaMd2");
            }
            else if (Application.loadedLevelName.Equals("loseMD1"))
            {

                Application.LoadLevel("InstaMd2");
            }

            else if (Application.loadedLevelName.Equals("winMD1"))
            {

                Application.LoadLevel("InstaMd2");
            }
            else if (Application.loadedLevelName.Equals("InstaMd2"))
            {

                Application.LoadLevel("mada3aTwo");
            }

            else if (Application.loadedLevelName.Equals("mada3aTwo"))
            {
                Application.LoadLevel("loseMD2");
                //Application.LoadLevel("InstaMd3");
            }
            else if (Application.loadedLevelName.Equals("loseMD2"))
            {

                Application.LoadLevel("InstaMd3");
            }


            else if (Application.loadedLevelName.Equals("winMD2"))
            {

                Application.LoadLevel("InstaMd3");
            }
            else if (Application.loadedLevelName.Equals("InstaMd3"))
            {

                Application.LoadLevel("mada3aThree");
            }
            else if (Application.loadedLevelName.Equals("mada3aThree"))
            {
                Application.LoadLevel("loseMD3");
                //Application.LoadLevel("InstaMd4");
            }
            else if (Application.loadedLevelName.Equals("loseMD3"))
            {

                Application.LoadLevel("InstaMd4");
            }

            else if (Application.loadedLevelName.Equals("winMD3"))
            {

                Application.LoadLevel("InstaMd4");
            }
            else if (Application.loadedLevelName.Equals("InstaMd4"))
            {

                Application.LoadLevel("mada3aFour");
            }
            else if (Application.loadedLevelName.Equals("mada3aFour"))
            {
                Application.LoadLevel("loseMD4");
                // Application.LoadLevel("InstaMd6");
            }
            else if (Application.loadedLevelName.Equals("loseMD4"))
            {

                Application.LoadLevel("InstaMd6");
            }

            else if (Application.loadedLevelName.Equals("winMD4"))
            {

                Application.LoadLevel("InstaMd6");
            }
            else if (Application.loadedLevelName.Equals("InstaMd6"))
            {

                Application.LoadLevel("mada3aSix");
            }
            else if (Application.loadedLevelName.Equals("mada3aSix"))
            {
                Application.LoadLevel("winMD6");
                //  Application.LoadLevel("InstaMd7");
            }
            else if (Application.loadedLevelName.Equals("winMD6"))
            {

                Application.LoadLevel("InstaMd7");
            }

            else if (Application.loadedLevelName.Equals("loseMD6"))
            {

                Application.LoadLevel("InstaMd7");
            }
            else if (Application.loadedLevelName.Equals("InstaMd7"))
            {

                Application.LoadLevel("mada3aSeven");
            }
            else if (Application.loadedLevelName.Equals("mada3aSeven"))
            {
                Application.LoadLevel("winMD7");
                //Application.LoadLevel("InstaMd8");
            }
            else if (Application.loadedLevelName.Equals("winMD7"))
            {

                Application.LoadLevel("InstaMd8");
            }

            else if (Application.loadedLevelName.Equals("loseMD7"))
            {

                Application.LoadLevel("InstaMd8");
            }
            else if (Application.loadedLevelName.Equals("InstaMd8"))
            {

                Application.LoadLevel("mada3aEight");
            }
            else if (Application.loadedLevelName.Equals("mada3aEight"))
            {
                Application.LoadLevel("winMD8");
                // Application.LoadLevel("InstaMd9");
            }
            else if (Application.loadedLevelName.Equals("winMD8"))
            {

                Application.LoadLevel("InstaMd9");
            }


            else if (Application.loadedLevelName.Equals("loseMD8"))
            {

                Application.LoadLevel("InstaMd9");
            }

            else if (Application.loadedLevelName.Equals("InstaMd9"))
            {

                Application.LoadLevel("mada3aNine");
            }
            else if (Application.loadedLevelName.Equals("mada3aNine"))
            {
                Application.LoadLevel("loseMD9");
                //Application.LoadLevel("InstaMd10");
            }
            else if (Application.loadedLevelName.Equals("winMD9"))
            {

                Application.LoadLevel("InstaMd10");
            }

            else if (Application.loadedLevelName.Equals("loseMD9"))
            {

                Application.LoadLevel("InstaMd10");
            }
            else if (Application.loadedLevelName.Equals("InstaMd10"))
            {

                Application.LoadLevel("mada3aTen");
            }
            else if (Application.loadedLevelName.Equals("mada3aTen"))
            {
                Application.LoadLevel("winMD10");
                //Application.LoadLevel("InstaMd11");
            }
            else if (Application.loadedLevelName.Equals("winMD10"))
            {

                Application.LoadLevel("InstaMd11");
            }

            else if (Application.loadedLevelName.Equals("loseMD10"))
            {

                Application.LoadLevel("InstaMd11");
            }
            else if (Application.loadedLevelName.Equals("InstaMd11"))
            {

                Application.LoadLevel("mada3aEleven");
            }
            else if (Application.loadedLevelName.Equals("mada3aEleven"))
            {
               // Application.LoadLevel("winMD11");
                Application.LoadLevel("loseMD11");
                // Application.LoadLevel("LevelMap");
            }
            else if (Application.loadedLevelName.Equals("winMD11"))
            {

                Application.LoadLevel("LevelMap");
            }
            else if (Application.loadedLevelName.Equals("loseMD11"))
            {

                Application.LoadLevel("LevelMap");
            }






            //////////////////////////////////////////Madar////////////////////////////////////////////

           else if (Application.loadedLevelName.Equals("InstaM1"))
            {

                Application.LoadLevel("MadarOne");
            }

            else if (Application.loadedLevelName.Equals("MadarOne"))
            {
                Application.LoadLevel("winM1");
                //Application.LoadLevel("InstaM2");
            }
            else if (Application.loadedLevelName.Equals("winM1"))
            {

                Application.LoadLevel("InstaM2");
            }

                      else if (Application.loadedLevelName.Equals("loseM1"))
            {

                Application.LoadLevel("InstaM2");
            }
            else   if (Application.loadedLevelName.Equals("InstaM2"))
            {

                Application.LoadLevel("MadarTwo");
            }

            else if (Application.loadedLevelName.Equals("MadarTwo"))
            {
                Application.LoadLevel("loseM2");
                //Application.LoadLevel("InstaM3");
            }
            else if (Application.loadedLevelName.Equals("loseM2"))
            {

                Application.LoadLevel("InstaM3");
            }

                      else if (Application.loadedLevelName.Equals("winM2"))
            {

                Application.LoadLevel("InstaM3");
            }
            else  if (Application.loadedLevelName.Equals("InstaM3"))
            {

                Application.LoadLevel("MadarThree");
            }

            else if (Application.loadedLevelName.Equals("MadarThree"))
            {
                Application.LoadLevel("LoseM3");
                // Application.LoadLevel("InstaM6");
            }
            else if (Application.loadedLevelName.Equals("LoseM3"))
            {

                Application.LoadLevel("InstaM6");
            }

                      else if (Application.loadedLevelName.Equals("winM3"))
            {

                Application.LoadLevel("InstaM6");
            }
            else   if (Application.loadedLevelName.Equals("InstaM6"))
            {

                Application.LoadLevel("MadarSix");
            }

            else if (Application.loadedLevelName.Equals("MadarSix"))
            {
                Application.LoadLevel("winM6");
                // Application.LoadLevel("InstaM9");
            }
            else if (Application.loadedLevelName.Equals("winM6"))
            {

                Application.LoadLevel("InstaM9");
            }

                      else if (Application.loadedLevelName.Equals("loseM6"))
            {

                Application.LoadLevel("InstaM9");
            }
            else    if (Application.loadedLevelName.Equals("InstaM9"))
            {

                Application.LoadLevel("MadarNine");
            }



            else if (Application.loadedLevelName.Equals("MadarNine"))
            {
                Application.LoadLevel("loseM9");
                // Application.LoadLevel("InstaM10");
            }
            else if (Application.loadedLevelName.Equals("winM9"))
            {

                Application.LoadLevel("InstaM10");
            }


                      else if (Application.loadedLevelName.Equals("loseM9"))
            {

                Application.LoadLevel("InstaM10");
            }
            else  if (Application.loadedLevelName.Equals("InstaM10"))
            {

                Application.LoadLevel("MadarTen");
            }

            else if (Application.loadedLevelName.Equals("MadarTen"))
            {
                Application.LoadLevel("winM10");
                //Application.LoadLevel("InstaM11");
            }
            else if (Application.loadedLevelName.Equals("winM10"))
            {

                Application.LoadLevel("InstaM11");
            }


                      else if (Application.loadedLevelName.Equals("loseM10"))
            {

                Application.LoadLevel("InstaM11");
            }
            else    if (Application.loadedLevelName.Equals("InstaM11"))
            {

                Application.LoadLevel("MadarEleven");
            }

            else if (Application.loadedLevelName.Equals("MadarEleven"))
            {
                Application.LoadLevel("loseM11");
                //Application.LoadLevel("winM11");
                //Application.LoadLevel("LevelMap");
            }
            else if (Application.loadedLevelName.Equals("winM11"))
            {


                Application.LoadLevel("LevelMap");
            }


 else if (Application.loadedLevelName.Equals("loseM11"))
            {


                Application.LoadLevel("LevelMap");
            }












        }

    }
}

