// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>

        public static bool FlashlightOn;

        public void Setup()
        {
            Window.SetTitle("My Dingle!");

            

            Window.SetSize(1280, 720);

        }

        public void ToggleFlashlight()
        {
            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                FlashlightOn = true;
            }
            if (Input.IsKeyboardKeyUp(KeyboardKey.Space) == true)
            {
                FlashlightOn = false;
            }
        }

        public void faces()
        {
            Draw.SetFillColor(246);
            Draw.Circle(Window.Width / Random.Integer(5, 15), Window.Height / Random.Integer(5, 15), 30);
        }

        /// <summary>
        ///     Update runs every frame
        /// </summary>
        ///         I knew that already!!!!! *aggressively flips the bird at you with both hands* - Hahs
        ///         
        //public static bool !IsMouseButtonDown(MouseButton Mouse1)
        //{
        //    return 0;
        //}
        public void Update()
        {
            Window.ClearBackground(0);
            Draw.SetLineSize(0);

            faces();

           // Draw.SetFillColor(240);

            // the flashlight
           ToggleFlashlight();
            if (FlashlightOn == true)
            {
                Draw.SetFillColor(130);

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 100);

                Draw.SetFillColor(180);

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 50);

                Draw.SetFillColor(240);

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 10);
            }
        }
    }

}
