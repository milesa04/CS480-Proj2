Haunted Jaunt - Assignment 2

Project Mechanics
Dot Product (The "Freeze" Mechanic): Located in WaypointPatrol.cs. It checks if John Lemon's forward vector matches the direction to the ghost. If you look at a ghost, it freezes! If you look away, it moves!

Linear Interpolation (The "Anger" Color): Located in EnemyColorChanger.cs. Uses Color.Lerp to smoothly turn the ghost from white to red the closer the player gets.

Particle Effect (The "Spooky Cloud"): Attached to the Ghost prefab. The emission rate is Lerped in EnemyColorChanger.cs so the red cloud gets thicker as you get closer.

Sound Effect (The "Shower" Trap): Located in the bathroom. Uses an invisible Box Collider and AudioTrigger.cs to play a sound when the player walks through it.