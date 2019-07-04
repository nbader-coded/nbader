using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacker : MonoBehaviour
{
    int level;
    enum screen { MainMenu, Password, win};
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }
    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        } else {
            selectlevel(input);

        }


    }
    void selectlevel(string inputlevel) {
        if (inputlevel == "1")
        {
            level = 1;
            StartGame();
            Terminal.WriteLine("you have chosen level: " + inputlevel);


        }
        else if (inputlevel == "2")
        {
            level = 2;
            StartGame();
            Terminal.WriteLine("you have chosen level: " + inputlevel);


        }

        }
    private void StartGame() {
        Terminal.WriteLine("you have chosen level: " + inputlevel);

    }
        
      
        




    

       
        
    
 
        //terminal.writeline("welcome agent" + name);
    

    void ShowMainMenu(string name)
    {
        Terminal.WriteLine("welcome agent hhh");
        Terminal.WriteLine("press 1 for coded");
        Terminal.WriteLine("press 2 for bank");
        Terminal.WriteLine("Enter your selection");
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
