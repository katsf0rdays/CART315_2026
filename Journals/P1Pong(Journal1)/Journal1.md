
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

- 


