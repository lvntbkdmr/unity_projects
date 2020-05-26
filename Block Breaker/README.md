# What I Have Learned

* Exporting the scenes from other NWU project and importing into this one. (Assets->Export Package, Assets->Import Package->Custom Package)
* Set Main Camera as Orthographic and Size as 6 (which means its height is total 12 unity units), so for 4:3 aspect ratio, its width will be 8+8 = 16 unity units
* Added a background sprite and calculated its pixel per units from = 1080/12 = 90
* Reset background position and adjust main camera's position (x=8, y=6)
* Make background far from the camera by assiging Z a positive number like Z = 1
* Make camera closer to the screen by assining Z a negative number like Z = -10
* Added RigigBody 2D to the ball and set its body type (gravity)
 - Dynamic : Controlled by physics engine
 - Kinetic : Subject to physics but can also be controlled with input (like paddle)
 - Static: static.
* Added Circle Collider to ball (which will be used to bounce)
* Added box collider to a block
* Added Polygon collider to the paddle
* Created physics material 2d and assigned to the ball collider (to make it bounce when collision happens)
* Created an empty gameobject(Lose Collider) and added a box collider 2d to it, resized it and checked "is triggered" 
* "Is triggered" triggers an event when a collision happens, but does not make collision happen (bounce material does not work) => Unity Doc-Physics-RigidBody-Collision Action Matrix
* using UnityEngine.SceneManagement; SceneManager.LoadScene
* Updating paddle position from Input.mousePosition
* Updating ball position from paddle position (LockBallToPaddle, LaunchOnMouseClick)
* Edit->Project Settings->Physics2D->Gravity = 0
* FindObjectsOfType
* Singleton pattern (https://docs.unity3d.com/Manual/ExecutionOrder.html)
* AudioClip and AudioSource (PlayClipAtPoint, PlayOneShot)
* [Range(0.1f, 10f)] [SerializeField]
* Instantiate GameObject out of Prefabs (Particle Effect VFX)
* Tags (Breakable, Unbreakable)
* Several sprites for different damage levels
* Autoplay

