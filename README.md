Haunted Jaunt - Assignment 2

Project Mechanics
Dot Product: Located in WaypointPatrol.cs. It checks if John Lemon's forward vector matches the direction to the ghost. If you look at a ghost, it freezes! If you look away, it moves!

Linear Interpolation: Located in EnemyColorChanger.cs. Uses Color.Lerp to smoothly turn the ghost from white to red the closer the player gets.

Particle Effect: Attached to the Ghost prefab. The emission rate is also Lerped in EnemyColorChanger.cs so the red cloud gets thicker as you get closer.

Sound Effect: Located in the bathroom. Uses an invisible Box Collider and AudioTrigger.cs to play a sound when the player walks through it.

Second Sound Effect: Located in the first two doorways that progress you through the game, gives a buzzing sound downloaded using a box collider and another audio trigger. 

Second Particle Effect: Attached to the gargoyles that is at a fixed rate 
