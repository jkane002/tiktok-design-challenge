# tiktok-design-challenge
Design challenge: Creating an AR filter for TikTok

# Description
A simple augmented reality feature where given a $20 on screen, a 3D bust of Harriet Tubman appears with a quote. Pressing the button will transform the dollar into a $20 bill featuring Tubman's face. This design only works with a $20 and no other denomination.
I chose this design because it reveals the ongoing effort to replace Andrew Jackson with Harriet Tubman on the $20 bill.

![alt text](https://github.com/jkane002/tiktok-design-challenge/blob/master/Screen%20Shot%202019-06-23%20at%203.00.34%20PM.png "screenshot")

# Challenges
Although it was my first time using augmented reality, it was very easy to understand the Vuforia Engine through Unity. Some challenges with it include setting up a picture that has easily defined trackers so the camera can detect objects.
This is suppose to be used in a mobile platform but its functionalities are demonstrated nicely through the computer's webcam.

# Bugs 
State machine when pressing the button sometimes wouldn't work. If a user, holds the button then the pictures glitch. A fix for this would be to design a better state machine acknowledging when the user holds and releases the button.

# Future Work
It would be nice to have the picture and the $20 featuring Harriet Tubman to bend when the user is bending the original $20. This effect can be achieved by creating a mesh renderer to the Harriet Tubman quote and her bill and transforming the vertices corresponding to the vertices of the original $20 bill.

Another feature I would like to implement is creating a more immersive experience where the 3D bust is speaking to the user. This requires 3D modeling of the bust so that different facial expressions can simulate Tubman speaking. This can be created in Autodesk Maya along with creating blendshapes. A dialogue textbox would also be next to her face so users can read exactly what she is saying.

# Credit
3D Model: https://free3d.com/3d-model/harriettubman-v3--97785.html
Quote: https://www.goalcast.com/2018/01/09/harriet-tubman-quotes-2/
