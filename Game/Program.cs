﻿using Game.Actors;
using Game.Actors.Button_and_door;
using Game.Commands;
using Game.Factories;
using Merlin2d.Game;
using Merlin2d.Game.Actors;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameContainer container = new GameContainer("Game window", 500, 500);

            container.SetMap("resources/maps/map01.tmx");
            container.GetWorld().SetPhysics(new Gravity());
            container.GetWorld().SetFactory(new ActorFactory());
            
            /*Door door = null;
            PressurePlate plate = null;
            int Num = 0;
            int GetNext() => ++Num;
            do
            {
                IActor doora = ((container.GetWorld().GetActors().Find(x => x.GetName() == $"Door-{GetNext()}")) != null) ? container.GetWorld().GetActors().Find(x => x.GetName() == $"Door-{Num}") : null;
                IActor plata = ((container.GetWorld().GetActors().Find(x => x.GetName() == $"Button-{GetNext()}")) != null) ? container.GetWorld().GetActors().Find(x => x.GetName() == $"Button-{Num}") : null;
                if (doora != null && plata != null)
                {
                    door = (Door)doora;
                    plate = (PressurePlate)plata;
                    Console.WriteLine("1");
                }
            } while (door != null && plate != null);*/
            //bool actor = ((container.GetWorld().GetActors().Find(x => x.GetName() == "Door")) !=null) ? true : false;
            //Console.WriteLine(actor);
            /*if (actor != false)
            {
                for (int x=0; x<20; x++)
                {
                    Console.WriteLine("1");
                }
            }*/
            container.GetWorld().AddInitAction((world) =>
            {
                IActor player = world.GetActors().ToList().Find(actor => actor is Player)!;
                world.CenterOn(player);
            }
           );
            container.SetCameraFollowStyle(Merlin2d.Game.Enums.CameraFollowStyle.CenteredInsideMapPreferTop);
            container.SetCameraZoom((float)1.3);
            container.Run();
        }
    }
}