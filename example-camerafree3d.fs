\ include raylib3.fs

800 Constant screenWidth
450 Constant screenHeight

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


: example-loop ( -- )
    begin
    exCamera UpdateCamera
    0.0e 0.0e 0.0e >Vector3 exCamera Camera3D-target toCamera
    BeginDrawing
    0xFFE4E100 Color allocate drop iGetColor ClearBackground 
    exCamera BeginMode3D
    cubePosition 2.0e 2.0e 2.0e 0xFF660001 Color allocate drop
    iGetColor DrawCube
    cubePosition 2.0e 2.0e 2.0e 0xCC660101 Color allocate drop
    iGetColor DrawCubeWires
    10 1.0e DrawGrid
    EndMode3D
    10 10 320 133 0x00331101 Color allocate drop
    iGetColor DrawRectangle
    10 10 320 133 0x00342501 Color allocate drop 
    iGetColor DrawRectangleLines
	EndDrawing
    again
;

: start ( -- )
    example-init
    example-init-camera
    example-loop ;