# What I Have Learned

- **Input.GetAxis("Horizontal")** gives the button press intensity between -1,+1 in the given axis.
- **Time.deltaTime** is multiplied by a value to make it fps independent.
- for examlple **(Input.GetAxis("Horizontal") * Time.deltaTime)** reaches to 1 in 1 second in any fps
- **ViewportToWorldPoint** is used to map viewport coordinates to our game world coordinates in unity units
- **StartCoroutine** is like spawning a new task
- **IEnumerator FireContinuously()** is non-returning task with infinite while loop, so it Instantiates the laser prefab and gives it an instant velocity. **yield return new WaitForSeconds** is used to delay the task so it determines its firing period.
- **StopCoroutine** is used to kill the task
- **Shredder → OnTriggerEnter2D** is used to destroy the collided objects (laser beams in this case)
- **Vector2.MoveTowards** is used to move objects through waypoints.
- **Edit→Project Settings→Physics 2D→Layer Collision Matrix** is used to manipulate the collision event between layers (Layers are created on the go such as Enemy, Player, Enemy Projectile, Player Projectile etc.)
- 3D Object → Quad is used to create **scrolling background** (Sprite should be Texture Type = Default, That texture is added into Quad and changed shader to unlit→texture, then a script is used to change its Y offset value)
- In order to change to material of Particle System, First you need to create a material (in VFX folder), then assing a sprite to it (a png file)) After that under Renderer of particle system, change the material
- **In order to make the buttons work in a UI, you need to have an Event System object inside the scene.**
- Game Object → Sprite Renderer → Additional Settings → Sorting Layer is used to determine the layer rendering order (first layer renders first so it stays on the backwards)