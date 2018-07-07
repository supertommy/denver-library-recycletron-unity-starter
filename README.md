# _Recycletron_ Starter Project 
**For Denver Library Game Development in Unity Bootcamp**

***

[See the Wiki for course lessons.](https://github.com/supertommy/denver-library-recycletron-unity-starter/wiki)

***

We will look at building a simple 2D game with the Unity game engine in this course. Knowledge of Unity is not required or assumed.

First, download the starter template project from Github: https://github.com/supertommy/denver-library-recycletron-unity-starter

This starter project gives us a template, pre-made scripts, and assets to build the rest of the game.

## Recycletron

The game is called _Recycletron_.

The objective of the game is to collect all recyclable items from the garbage as they fall from the top of the screen.

Items will fall faster and faster as the game progresses.

Players are awarded points for each recyclable item selected. A life is lost for each non-recyclable item selected or if a recyclable item is missed. An item is missed once it falls off screen.

## What we will build

The game will go from a title screen to the actual game. There will be a pause screen where the player can choose to mute any music and sound effects as well as quit the game. A game over screen will appear once the player loses all their lives.

We will go through the process of connecting all the pieces into a coherent game and implement game play logic.

The starter project provides Scenes and Scripts to guide us along without having to start from absolute scratch.

Here are some of the things we will learn to do in this course:

- respond to button clicks
- respond to clicks on falling items
- basic usage of the Unity 2D physics system
- work with and create Scenes
- create and spawn Prefabs
- play music and sound effects
- keep track of and modify game state (score and lives)
- download assets from the Unity Asset Store

## Starter Project Overview

Like all Unity projects, all files related to the game will reside in the `Assets` folder. The other folders on the same level as `Assets` (like Library and Temp) are generally managed by Unity and we don't need to worry about it.

We have 6 other folders in the `Assets` folder:

- Audio
- Fonts
- Prefabs
- Scenes
- Scripts
- Textures

Let's get a quick overview of each.

### Audio

We have a pre-made AudioMixer ready for use. [You can learn more about the AudioMixer here.](https://docs.unity3d.com/Manual/AudioMixer.html)

There are a lot of complex and interesting effects that can be done with the AudioMixer but we won't be getting into those. We are going to use the AudioMixer to control volume of the music and sound effects in the game.

### Fonts

This folder has 3 fonts that we will use across the game for stylistic purposes. Unity's default UI font is Arial.

### Prefabs

We have a few pre-made Prefabs for audio as well as garbage and recyclable items. Any new Prefabs we make will be placed here for organizational purposes.

[You can learn more about Prefabs here.](https://docs.unity3d.com/Manual/Prefabs.html)

You can think of Prefabs as a template from which you can create copies. It is useful when you want to use the same object in multiple places. You can have 1 master version and then make many copies of it.

Don't worry if this doesn't make much sense yet. It will make more sense once you actually use them.

### Scenes

Scenes are self-contained sections of your game. We will be using Scenes to separate our Title screen, Game, and Game Over screen.

[You can learn more about Scenes here.](https://docs.unity3d.com/Manual/CreatingScenes.html)

We will create a Game Over Scene that will be placed in this folder later.

### Scripts

All of our code lives in this folder and will be written in C#.

We will mostly be using and implementing missing logic from these existing Scripts. We will create some Scripts from scratch to demonstrate how that is done.

### Textures

This folder contains the 2D graphics used in the game except for the garbage and recycles which are found in a Textures folder under the Prefabs folder.

Textures are basically any image file.

***

That's an overview of what we'll be doing. 

The first thing we will do is to reset the Unity editor layout to "Default" so that we are all using the same layout of panels. Select `Window > Layouts > Default` to do this.

Then we will set the Aspect Ratio to 16:9. Select the Game panel and find the drop down that says "Free Aspect". Click it and select "16:9". We are going to design this game for standard widescreen resolutions for simplicity.

[Next we will start by connecting the Titlescreen Scene to the Game Scene so that we can press "Play" and jump into the Game Scene](https://github.com/supertommy/denver-library-recycletron-unity-starter/wiki/1.-Building-a-Titlescreen)

