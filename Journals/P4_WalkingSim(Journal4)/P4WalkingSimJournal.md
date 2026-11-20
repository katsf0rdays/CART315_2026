

List of things to accomplish

-> Add more sounds when walking
-> More sprites, choose any that are grass related
-> Water effects on screen
-> Doors that open
-> Possibly bubbles that pop that the use must find around the map - for which a counter will be added 
 

==🟡Day 1==

-> Dynamic/moving assets
 - I was able to find some asset folders that included the assets that I wanted but they are static so I need to figure how to make them feel as though they are flowing in water. 
- I really wanted to make the static prefabs be able to move. So with a lot of time going back and forth, consulting tutorials and using AI for specific errors, I was able to accomplish that by creating a custom vertex displacement shader. 
	- This was quite difficult for me because of all the different nodes that had to be created and implemented together as a whole. A *lot* of going back and forth, to make sure each node was linked together properly. 
	- Also, it was sort of confusing of how to implement the shader, since the UI is sort of hard to sift through when it comes to navigating materials, shaders, textures etc. I was also questioning whether or not to implement something on the material itself or the prefab of an asset, so figuring that out was also tedious. 


-> Double doors
- Another aspect I wanted to incorporate are double doors on each of the large openings within my lost relic sketchfab. 
	- It was a little daunting given the tutorial in class was considered the baseline and being told that it was relatively more complicated to implement. 
	- With to tutorial consultations, it was actually more heavy on the coding aspect rather than intricacies concerning the inspector or the object itself. 
	- Therefore it wasn't necessarily difficult, it was just being able to understand the code related to it and manipulating the position of the pivot in the scene for both sides of the door. 
	- I also spent some time looking for materials that would make sense for the doors. I wasn't able to get exactly what I wanted because the doors are flat, derived from a cube compared to the lost relic sketchfab that is dynamic in terms of its shape. 


-> Sound implementation
- This was something that was given to me as a recommendation which made a lot of sense but I wasn't sure if I wanted to put time into this due to having other things that were deemed more important with this assignment. However, after incorporating a couple of other sounds, it was well worth it and it definitely added more to the immersion.  
	- At first, I looked for the recommended "bubbles" sound to implement alongside the neutral atmospheric sound the walking sim already possessed. 
	- Another sound I wanted to implement was that of walking on the sand of my terrain. Specifically, for when the player pressed "w" but also increasing the speed of the audio when the player pressed "shift", a makeshift way of making a sprint audio out of the original track. 
	- This however, due to having multiple audios, there was a lot of conflicting errors that would come up. Which includes either only the ambient + sand audios playing, or only the bubbles + sand and not the ambient etc. With a lot of trial and error and using AI for specific error handling, I had to create 3 audio sources and then tweak the footsteps script. 


==🟡Day 2==

-> Water sky effects 
- This to me is the most daunting step, as there are so many ways to go by it. Initially my goal was to make it look underwater as much as possible and to incorporate some bubble effects to enhance that feeling even more. 
- This however did not come to fruition fully because it would have required much more work then I had time for. 
	- Through consulting tutorials, I had essentially two options for giving the sky a water look. I chose in the end to do it through a creation of a 3D sphere object, enlarge it to be over my entire terrain and to apply a material that was made through a shader. 
	- Once again, using all of the different types of nodes and having to replace them with others to get the effects I wanted was really tedious. 
	- Error handling was the most annoying, because a lot of the time in scene view it would expand to the whole screen to a blue shimmer but in game view there was nothing actually present to see. 
	- So I figured out eventually that the sphere itself was not in distance with my terrain, so I had to change it's position to match that.
	- Also a big part of this day was figuring out reasons I couldn't drop materials into different objects/assets, which took up some time as well. 


-> Blue mask overtop 
- While error handling, (mostly with AI), it suggested adding a sort of "blue hue" of a filter over the game, which I wanted to do anyways, using the Global Volume object. 
- Both this step and the previous one are sort of interchangeable because I had to figure out and understand how I wanted to apply a material to the sky as well as a visual to the environment itself. 
	- Through a lot of trial and error, which included making unnecessary scripts, and fiddling around with the environment tab in the lighting settings - window > rendering > lighting > environment, I was able to create the effect I wanted. 
	- In the end, I had to simply change the colour and the lens distortion within the Global Volume object to achieve the desired effect. 


-> Counter UI + Ending screen 
- This was pretty straight forward as it was more codding heavy then anything else. 
	- Initially I wanted to create a more finished end screen but that didn't end up happening due to my timeframe. 
	- I ended up instead creating a panel with a transparent blue tint which became my end screen, which triggered when the user collecting all of the bubbles/when the bubble counter hit 20. 
	- Two scripts were created for this, which in goes hand in hand with bubble collecting; those being a Counter UI, which handled the UI at the top of the screen changing with the bubble collecting, and the BubblePickup which deletes the bubble objects when the user interacts with them but also adds 1 to the bubble counter. 


-> Bubble Collecting
- The only tedious thing was figuring out how to make a bubble like material as I tried using an imported vfx version of a bubble and I wasn't able to turn it into a proper material to put over a 3D sphere object. 
	- To make it relatively simple, my idea was that the player would go around collecting bubbles as the goal and then would be prompted with an end screen once having collected all of them.
	- I made the goal to collect 20 bubbles for simplicity and I wanted a few things to be incorporated which included the following: 
		- An object that actually looked like a bubble (in terms of transparency etc).
		- For the bubble to disappear once the user interacted with it.
		- For the counter to increase once the user interacted with it. 
		- For a popping sound to go off once interacting with it. 
	- All of these elements were incorporated, as it wasn't necessarily difficult in terms of coding nor how the sound was implemented. I just needed to change the length of the sound to match when the player came into contact with the bubble itself. 

