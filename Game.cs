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

            

            Window.SetSize(400, 400);



            

        }

        //public void ToggleFlashlight()
        //{
        //    if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
        //    {
        //        FlashlightOn = true;
        //    }
        //    if (Input.IsKeyboardKeyUp(KeyboardKey.Space) == true)
        //    {
        //        FlashlightOn = false;
        //    }
        //}

        public void faces()
        {
            Draw.SetFillColor(246);
            Draw.Circle(Random.Integer(10, 1270), Random.Integer(10, 710), 30);
        }

        /// <summary>
        ///     Update runs every frame
        /// </summary>       

        //random coordinates for generating the objects

        public static int RandomCoordinate = Random.Integer(10, 390);
            

        public void Update()
        {
            Draw.SetLineSize(0);

            Window.ClearBackground(0);

            //vars involving the points

            bool GeneratePoint = true;



            // the flashlight

            //ToggleFlashlight();

            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                FlashlightOn = true;
            }
            else
            {
                FlashlightOn = false;
            }

            //if (flashlight == true)
            //{
            //    Draw.SetFillColor(255);

            //    Draw.Circle(Window.Width / 2, Window.Height / 2, 100);

            //}
            //flashlight = false;

            if (FlashlightOn == true)
            {
                Draw.SetFillColor(230, 128);

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 30);

                Draw.SetFillColor(255, 148);

                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 15);

                //while (Name == true)
                //{
                //    faces();
                //}
                //Name = false;
            }

                if (GeneratePoint == true)
                {
                    Draw.SetFillColor(240);

                    Draw.Circle(RandomCoordinate, RandomCoordinate, 15);

                }
            GeneratePoint = false;
            }

        }

    }
