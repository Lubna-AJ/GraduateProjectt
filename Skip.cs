using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Escape))
        {


            if (Application.loadedLevelName.Equals("SoukM"))
                Application.LoadLevel("LevelMap");

            else if (Application.loadedLevelName.Equals("SoukMD"))
                Application.LoadLevel("LevelMap");

            else if (Application.loadedLevelName.Equals("SoukJ"))
                Application.LoadLevel("LevelMap");


        }   

	}

    //giftTxxxx 

    public void GiftTh()
    {
      
        Application.LoadLevel("Gift");
    }



    //Janabi

    public void InstJ()
    {

        Application.LoadLevel("InstaJ1");
    }

    public void J1() {

        Application.LoadLevel("JanabiOne");
    }

    public void J2()
    {

        Application.LoadLevel("JanabiTwo");
    }
    public void J3()
    {

        Application.LoadLevel("JanabiThree");
    }

    public void J6()
    {

        Application.LoadLevel("JanabiSix");
    }

    public void J9()
    {

        Application.LoadLevel("JanabiNine");
    }
    public void J10()
    {

        Application.LoadLevel("JanabiTen");
    }

    public void J11()
    {

        Application.LoadLevel("JanabiEleven");
    }


    //mada3a


    public void InstMD1()
    {

        Application.LoadLevel("InstaMd1");
    }

    public void MD1()
    {

        Application.LoadLevel("mada3aOne");
    }

    public void MD2()
    {

        Application.LoadLevel("mada3aTwo");
    }

    public void MD3()
    {

        Application.LoadLevel("mada3aThree");
    }
    public void MD4()
    {

        Application.LoadLevel("mada3aFour");
    }
    public void MD6()
    {

        Application.LoadLevel("mada3aSix");
    }
    public void MD7()
    {

        Application.LoadLevel("mada3aSeven");
    }
    public void MD8()
    {

        Application.LoadLevel("mada3aEight");
    }
    public void MD9()
    {

        Application.LoadLevel("mada3aNine");
    }
    public void MD10()
    {

        Application.LoadLevel("mada3aTen");
    }
    public void MD11()
    {

        Application.LoadLevel("mada3aEleven");
    }

    //Madar


    public void InstM1()
    {

        Application.LoadLevel("InstaM1");
    }
    public void M1()
    {

        Application.LoadLevel("MadarOne");
    }


    public void M2()
    {

        Application.LoadLevel("MadarTwo");
    }

    public void M3()
    {

        Application.LoadLevel("MadarThree");
    }
    public void M6()
    {

        Application.LoadLevel("MadarSix");
    }

    public void M9()
    {

        Application.LoadLevel("MadarNine");
    }
    public void M10()
    {

        Application.LoadLevel("MadarTen");
    }
    public void M11()
    {

        Application.LoadLevel("MadarEleven");
    }




}
