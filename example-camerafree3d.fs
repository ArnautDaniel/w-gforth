include raylib3.fs

800 Constant screenWidth
450 Constant screenHeight

( RED MAROON SKYBLUE BLUE BLACK DARKGRAY )

: >Color ( r g b a -- Color )
    Color allocate throw { col }
    col Color-a c!
    col Color-b c!
    col Color-g c!
    col Color-r c! col ;

230 41 55 255 >Color Constant RED
190 33 55 255 >Color Constant MAROON
102 191 241 255 >Color Constant SKYBLUE
0 121 241 255 >Color Constant BLUE
0 0 0 255 >Color Constant BLACK
80 80 80 255 >Color Constant DARKGRAY
245 245 245 255 >Color Constant RAYWHITE

: example-init ( -- )
  screenWidth screenHeight
  s" raylib [core] example - 3d camera free"
  InitWindow ;

Camera3D allocate drop Value exCamera


: >Vector3 ( f: -- x y z -- Vector3 )
    Vector3 allocate throw { Vec3 }
    Vec3 Vector3-z sf!
    Vec3 Vector3-y sf!
    Vec3 sf! Vec3 ;

: Vector3> ( Vector3 -- f: -- x y z )
    { Vec3 }
    Vec3 sf@
    Vec3 Vector3-y sf@
    Vec3 Vector3-z sf@ ;

: toCamera ( Vector3 Camera -- )
    { Vec3 Cam }
    Vec3 Vector3>
    Cam Vector3-z sf!
    Cam Vector3-y sf!
    Cam Vector3-x sf! ;

10.0e 10.0e 10.0e >Vector3 Value position
0.0e 0.0e 0.0e >Vector3 Value target
0.0e 1.0e 0.0e >Vector3 Value up
45.0e fvalue fovy

: example-init-camera ( -- )
    position exCamera toCamera
    target exCamera Camera3D-target toCamera
    up exCamera Camera3D-up toCamera
    fovy exCamera Camera3D-fovy sf!
    CAMERA_PERSPECTIVE exCamera Camera3D-type ! ;

0.0e 0.0e 0.0e >Vector3 Value cubePosition

: example-text ( -- )
    10 10 320 133 SKYBLUE DrawRectangle
    10 10 320 133 BLUE DrawRectangleLines
    s" Free camera default controls:" 20 20 10 BLACK DrawText
    s" - Mouse Wheel to Zoom in-out" 40 40 10 DARKGRAY DrawText
    s" - Mouse Wheel PRessed to Pan" 40 60 10 DARKGRAY DrawText
    s" - Alt + Mouse Wheel Pressed to Pan" 40 80 10 DARKGRAY DrawText
    s" - Alt + Ctrl + Mouse Wheel Pressed for Smooth Zoom" 40 100 10 DARKGRAY DrawText
    s" - Z to zoom to (0, 0, 0)" 40 120 10 DARKGRAY DrawText ;

: example-cube ( -- )
    cubePosition 2.0e 2.0e 2.0e RED DrawCube
    cubePosition 2.0e 2.0e 2.0e MAROON DrawCubeWires
    10 1.0e DrawGrid ;

: example-reset ( -- )
    KEY_Z IsKeyDown if
	0.0e 0.0e 0.0e >Vector3 exCamera
	Camera3D-target toCamera
    then ;

: example-loop ( -- )
    begin
	exCamera UpdateCamera
	example-reset
	BeginDrawing
	RAYWHITE ClearBackground 
	exCamera BeginMode3D
	example-cube
	EndMode3D
	example-text
	EndDrawing
    WindowShouldClose until ;

: start ( -- )
    example-init
    example-init-camera
    exCamera CAMERA_FREE SetCameraMode
    60 SetTargetFPS
    example-loop
    CloseWindow ;
