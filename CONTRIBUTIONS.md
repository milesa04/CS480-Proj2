# Team Contributions

## Miles A
- **Enemy Color Lerp** (`EnemyColorChanger.cs`): Used `Color.Lerp` to smoothly transition ghost enemies from white to red as the player gets closer.
- **Ghost Particle Effect** (`EnemyColorChanger.cs` + Ghost prefab): Attached a particle effect to the Ghost prefab whose emission rate is also lerped — the red cloud grows thicker the closer the player gets.

## Chris (1barbato)
- **Player Walking Particle Effect**: Added a dust particle effect attached to John Lemon (the player character) that plays while he walks.

## Hayden O
- **Doorway Sound Triggers**: Added audio triggers on the first two doorways using invisible Box Colliders and `AudioTrigger.cs` to play a buzzing sound as the player walks through.
- **Gargoyle Particle Effects**: Attached a fixed-rate particle effect to the gargoyle objects in the scene.
- **Gargoyle Assets**: Added the gargoyle 3D model, animations, materials, textures, and prefab to the project.

## Ethan T
- **AudioTrigger Fix** (`AudioTrigger.cs`): Added a `[FormerlySerializedAs("spookySound")]` attribute to handle field renaming without losing serialized data, and added a null check before playing audio to prevent crashes.
- **Scene Wiring** (`MainScene.unity`): Connected the AudioTrigger component's `showerSound` and `player` fields to their actual scene objects (they were previously unassigned, so the audio trap would never fire).
- **Solution File** (`CS480-Proj2.slnx`): Added the Visual Studio solution file for the project.
