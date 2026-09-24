
==2026/09/21==

Goal: to change the background color whenever a paddle hits the ball
- Created a new script for the Background asset. 
- Added a camera and color variable. 
- Added a OnCollisionEnter2D constructor which changes the color of the background if the game object (ball) enters/collides with another object of a certain tag, in this case being "Paddle".
- Figured out how to utilize tags within game objects via research.
- Created a tag named "Paddle" and attached it to each of the paddles (PaddlePlayer and PaddleCPU).
- Realized that I actually needed to put all of this code into the Ball object script instead of the Background object script so I changed that. 



==2026/09/22==

Goals: 
1. To keep the velocity constant on the ball game object even if there is collision with another game object (paddle or court).
2. To make two balls spawn from every collision of a ball with a paddle. 

- Summary - a lot of research and debugging, in the end, was able to maintain a constant velocity on the ball, however, instead of more balls spawning after a collision with a paddle, balls spawned after every round was started. 
- Bugs that I came across:
1. The left side court was able to be collided with, thus not resulting in a goal for the npc. -> Had to create a trigger for both sides of the court to be checked if the ball came into contact with either side using tags. Also had to disable some physics elements on the court game object. 
2. Memory overload due to an infinite loop of balls spawning after each round, which caused my unity to freeze. -> Had to cap the amount of balls spawned by 100. 


==2026/09/23==

Reflection for this assignment

This was a fun assignment, especially watching the fruits of my labor come to fruition. Debugging will always be the most frustrating part, but that just comes with the process. This is my second time using unity since building a game back in 2022, and I will say the user interface is quite daunting when coming back to use it, especially with all of the components available for use and the code that has to be intergraded. 

I think with my background knowledge of object oriented programing (using Java) through the classes I am currently taking has helped me a lot with understanding what the code does, aside from a few Unity and C# exclusives. 

Going into the assignment, I had a vision as to what I wanted the game to look like, that being a sort of almost epileptic experience. Where balls would just keep spawning and the color of the background would keep changing as the balls would exponentially keep colliding with the paddles as they spawned. Fortunately I was able to achieve this goal to almost a one to one of what I imagined, so I am happy for that outcome, aside from the fact that the condition for the balls spawning was not colliding with a paddle but the start of a new round. 

