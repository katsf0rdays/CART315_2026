

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

