# VR Nostalgia Project

## Description

This project is a VR nostalgia experience built in Unity. The idea is to recreate a childhood bedroom where the user can interact with different objects and make the space feel nostalgic and immersive.

The room is meant to feel like a childhood bedroom with toys, sounds, videos, and small interactions that remind the user of older memories. Right now, we are focused on making the room feel more alive by adding sit points, grabbable objects, sounds, videos, and different interactive details around the room.

## What Works

Right now we have three sit points:

- Bed
- Beanbag
- Desk chair

The sit points are trigger based, so when the user triggers one of the sit areas, it moves them into that sitting position.

We also have a highlight script that highlights certain objects so the user can tell what they can interact with. The highlighted objects include:

- Bed
- Beanbag
- Desk chair
- iDog
- Easel

We also have a ceiling fan script that allows the fan blades to spin. This is a smaller detail, but it helps the room feel less static.

## Grabbable objects and sound interactables

We have a lot of grabbable objects around the room. Some of them make sounds, and some are just there to make the room feel more realistic and interactive.

### Stuffed animals on the bed

The stuffed animals are all grabbable and also have sounds attached.
- Lobster
- Bear
- Pig
- Penguin
- Llama
- Dino

### Other sound interactables

- Flip phone
  - Grabbable
  - Has a ringer sound attached

- iDog
  - Not grabbable
  - Makes a sound when triggered
  - Highlights when interactable

### Desk objects

Some things on the desk are grabbable, including:
- Diary of a Wimpy Kid book
- Candy bracelet
- Behavior card

### Dolls and toys

These are grabbable but do not have sound attached:
- 2 Barbie dolls
- 2 Bratz dolls
- Tamagotchi on the bedside table
- VHS tapes on the TV stand

## TV interaction

The TV has scripts attached to it that play a startup sound and then start the video player. This makes the TV interaction feel more like turning on an older TV instead of just having the video start right away.

This is one of the main interactions in the room because the TV helps add to the nostalgic feeling of the project.

## Easel interaction

There is also an easel in the room that changes drawings when it is triggered. This is controlled with a script and adds another small interactive detail to the space.

The easel also uses the highlight script so the user can tell that it is interactable.

## Radio interaction

The radio can toggle on and off. It also has buttons that allow the user to skip songs when they are triggered.

This makes the radio feel more interactive instead of just being a background object.

## Ceiling fan interaction

We also have a ceiling fan script that makes the fan blades spin. This helps the room feel more alive and adds movement to the environment.

## Videos

### Project Video

Checkpoint 1: https://youtu.be/m2i1una88eQ
Checkpoint 2: https://youtu.be/3L6y5B2tj5c

### Code Video

Checkpoint 1: https://youtu.be/xcYaRdA9RnQ
Checkpoint 2: https://youtu.be/PLn6NMdVk-I

## Paper

### Overleaf
Checkpoint1: 
Checkpoint_1_CS465.pdf  
https://www.overleaf.com/read/xcbwvtxyhvbt#15329f

Checkpoint2: 
[ADD HERE WHEN WE UPDATE!]


## How it works

We used Unity with the XR Interaction Toolkit.

The sit points are trigger based and move the user into a sitting position. We used this for the bed, beanbag, and desk chair so the user can sit in different areas of the room.

Most of the grabbable objects use XR Grab Interactable. This lets the user pick up different toys and objects around the room with the VR controller.

Some objects also have audio attached to them, like the stuffed animals, flip phone, iDog, and radio. These sounds help make the room feel more fun and nostalgic.

The highlight script is used on objects like the bed, beanbag, desk chair, iDog, and easel. This helps show the user what they can interact with.

The TV uses scripts to play a startup sound and then play the video. The easel uses a script to change drawings when triggered. The radio uses a script to toggle music on and off and skip songs with buttons. The ceiling fan uses a script to rotate the fan blades.

Overall, we tried to make the room feel like there are a lot of little things to discover, instead of it just being a static bedroom.

## Where we are right now

At this point, we have a working room with multiple interactions. The user can sit in different places, pick up toys and objects, trigger sounds, turn on the TV, interact with the easel, use the radio, and see small details like the ceiling fan moving.

The project is still not fully finished, but the main idea is there. The bedroom works like a nostalgia hub where the user can look around, interact with different objects, and experience small memory-based moments.

## Bugs we still need to fix

There are still a few bugs we want to fix in the future:

- Sometimes the player ends up taller after colliding with the beanbag, desk chair, or bed.
  - This probably has to do with the sit point or collider setup, so we need to adjust the collision areas and make sure the player height resets correctly.

- The TV screen sometimes automatically stays on the last screenshot of the scene when reopening the game.
  - We need to make sure the TV screen resets back to the off material when the scene starts.

- The buttons on the TV and radio do not highlight.
  - This makes it harder for users to know where they are supposed to trigger the interaction, so we want to add highlighting to those buttons.

- Objects can get lost outside the room when they are thrown.
  - We want to add boundaries or a reset system so objects can come back if they leave the playable area.

- The dino stuffed animal does not have the best collider box.
  - When it spawns, it sometimes rocks back and forth, so we need to adjust the collider or rigidbody settings to make it more stable.

## What we want to add next

Next, we want to keep improving the room and make the interactions feel more polished. We want to make sure the objects feel natural to pick up and that the sounds and triggers work smoothly.

We also want to fix the current bugs, like the player height changing near sit points, the TV screen not resetting correctly, objects getting thrown outside the room, and the dino collider issue.

Another thing we want to improve is user feedback. Right now, the TV and radio buttons do not highlight, so users may not know where to press or trigger. Adding highlights to those buttons would make the interactions easier to understand.

Eventually, we would like to expand past just the bedroom and maybe add more rooms in the house. That way the experience feels bigger and gives the user more places to explore.

Overall, we just want the space to feel more interactive, immersive, and nostalgic instead of static.

## Tools used

- Unity
- XR Interaction Toolkit
- C# scripts
- Unity Video Player
- Audio Sources
- XR Grab Interactable
- VR interaction components

## Contributors

Brittany Gutierrez & Nathan Chapman  
Colorado State University <3
