
10/23/2026

Brainstorming

- Initial idea: dodging simulator with infinite spawning projectiles.
- Something that is similar to dodging horizontal lazers coming towards the player.
- No increasing number
- Inspired by the geometry dash game mode called UFO, to Jetpack Joyride or the game that pops up in your google browser when you have no wifi.


10/25/2026

Took a lot of time trying to figure out how I wanted to realize this project due given my initial idea but then pivoted to a more lighter themed game. 
- Still stayed with the idea of a dodging similar except I made it a cat jumping over obstacles instead. 
- I knew that I wanted to incorporate an animation of a pixel cat that I made myself and used from a previous project. 

Took a lot of time understanding how the background was able to be an infinite loop and how I can apply that to other background sprites of my choosing by adjusting x and y values as well as other settings. This changed depending on the file imported so I had to fiddle around a lot with that. 

Changing around the different sprites weren't too difficult just a little tedious due to little mistakes that can be made while transferring pngs. Very much a lot of trial and error by comparing sprites/prefabs to make sure some maintain certain attributes and similarities so the scripts run how they are supposed to when tailored to another prefab or sprite.  

In terms of the scripts, I had to simplify some code due to having one singular obstacle instead of two at the same time via the pipes. Additionally, I changed a good portion of the Spawner script because I wanted my cloud sprite to spawn in a more randomized fashion compared to the previous pipes. Therefore I had to take into consideration the size of the canvas and adjust the spawning sequences in that way. 
Other scripts changed more then others included the Player and Clouds (previously Pipes) scripts. The former I had to change due to the change in animations from the new sprites I imported and the latter being a more simplified version of the pipes as mentioned above.  

Along the way, learning and implementing new classes such as IEnumerator as well as Coroutine was interesting.

Overall I did achieve the vision of what I wanted for this game and I was quite happy with how it turned out given my time.  

If I were to add anything else it would be:
- More clouds spawning -> which increases the difficulty 
- More mechanics/obstacles or different types of clouds that allow the player to pass through them and claim different effects -> more dynamic gameplay and adds more complex elements
- The hit box of the cloud isn't exactly to my liking to I would want to make that more accurate instead of it being fixed to a box size. -> more fair for the player and avoids random clipping of the clouds when the player has clearly not hit the cloud 
- I wanted the cat to be in the jumping animation as soon as the player presses the start button. -> quality of life/visual improvement 