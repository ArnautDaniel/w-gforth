\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ UPDATE: File modified by hand to fix broken functions
\ Gforth does not support returning structures.
\ Functions that do that are wrapped to return a pointer instead.

\ ----===< prefix >===-----
c-library raylib
s" raylib" add-lib
\c #include "raylib.h"

\ ---===< float constants >===----
3.141593e0	fconstant PI
0.017453e0	fconstant DEG2RAD
57.295776e0	fconstant RAD2DEG

\ --------===< enums >===---------
\ enum ConfigFlag
#1	constant FLAG_RESERVED
#2	constant FLAG_FULLSCREEN_MODE
#4	constant FLAG_WINDOW_RESIZABLE
#8	constant FLAG_WINDOW_UNDECORATED
#16	constant FLAG_WINDOW_TRANSPARENT
#128	constant FLAG_WINDOW_HIDDEN
#256	constant FLAG_WINDOW_ALWAYS_RUN
#32	constant FLAG_MSAA_4X_HINT
#64	constant FLAG_VSYNC_HINT
\ enum TraceLogType
#0	constant LOG_ALL
#1	constant LOG_TRACE
#2	constant LOG_DEBUG
#3	constant LOG_INFO
#4	constant LOG_WARNING
#5	constant LOG_ERROR
#6	constant LOG_FATAL
#7	constant LOG_NONE
\ enum KeyboardKey
#39	constant KEY_APOSTROPHE
#44	constant KEY_COMMA
#45	constant KEY_MINUS
#46	constant KEY_PERIOD
#47	constant KEY_SLASH
#48	constant KEY_ZERO
#49	constant KEY_ONE
#50	constant KEY_TWO
#51	constant KEY_THREE
#52	constant KEY_FOUR
#53	constant KEY_FIVE
#54	constant KEY_SIX
#55	constant KEY_SEVEN
#56	constant KEY_EIGHT
#57	constant KEY_NINE
#59	constant KEY_SEMICOLON
#61	constant KEY_EQUAL
#65	constant KEY_A
#66	constant KEY_B
#67	constant KEY_C
#68	constant KEY_D
#69	constant KEY_E
#70	constant KEY_F

#71	constant KEY_G
#72	constant KEY_H
#73	constant KEY_I
#74	constant KEY_J
#75	constant KEY_K
#76	constant KEY_L
#77	constant KEY_M
#78	constant KEY_N
#79	constant KEY_O
#80	constant KEY_P
#81	constant KEY_Q
#82	constant KEY_R
#83	constant KEY_S
#84	constant KEY_T
#85	constant KEY_U
#86	constant KEY_V
#87	constant KEY_W
#88	constant KEY_X
#89	constant KEY_Y
#90	constant KEY_Z
#32	constant KEY_SPACE
#256	constant KEY_ESCAPE
#257	constant KEY_ENTER
#258	constant KEY_TAB
#259	constant KEY_BACKSPACE
#260	constant KEY_INSERT
#261	constant KEY_DELETE
#262	constant KEY_RIGHT
#263	constant KEY_LEFT
#264	constant KEY_DOWN
#265	constant KEY_UP
#266	constant KEY_PAGE_UP
#267	constant KEY_PAGE_DOWN
#268	constant KEY_HOME
#269	constant KEY_END
#280	constant KEY_CAPS_LOCK
#281	constant KEY_SCROLL_LOCK
#282	constant KEY_NUM_LOCK
#283	constant KEY_PRINT_SCREEN
#284	constant KEY_PAUSE
#290	constant KEY_F1
#291	constant KEY_F2
#292	constant KEY_F3
#293	constant KEY_F4
#294	constant KEY_F5
#295	constant KEY_F6
#296	constant KEY_F7
#297	constant KEY_F8
#298	constant KEY_F9
#299	constant KEY_F10
#300	constant KEY_F11
#301	constant KEY_F12
#340	constant KEY_LEFT_SHIFT
#341	constant KEY_LEFT_CONTROL
#342	constant KEY_LEFT_ALT
#343	constant KEY_LEFT_SUPER
#344	constant KEY_RIGHT_SHIFT
#345	constant KEY_RIGHT_CONTROL
#346	constant KEY_RIGHT_ALT
#347	constant KEY_RIGHT_SUPER
#348	constant KEY_KB_MENU
#91	constant KEY_LEFT_BRACKET
#92	constant KEY_BACKSLASH
#93	constant KEY_RIGHT_BRACKET
#96	constant KEY_GRAVE
#320	constant KEY_KP_0
#321	constant KEY_KP_1
#322	constant KEY_KP_2
#323	constant KEY_KP_3
#324	constant KEY_KP_4
#325	constant KEY_KP_5
#326	constant KEY_KP_6
#327	constant KEY_KP_7
#328	constant KEY_KP_8
#329	constant KEY_KP_9
#330	constant KEY_KP_DECIMAL
#331	constant KEY_KP_DIVIDE
#332	constant KEY_KP_MULTIPLY
#333	constant KEY_KP_SUBTRACT
#334	constant KEY_KP_ADD
#335	constant KEY_KP_ENTER
#336	constant KEY_KP_EQUAL
\ enum AndroidButton
#4	constant KEY_BACK
#82	constant KEY_MENU
#24	constant KEY_VOLUME_UP
#25	constant KEY_VOLUME_DOWN
\ enum MouseButton
#0	constant MOUSE_LEFT_BUTTON
#1	constant MOUSE_RIGHT_BUTTON
#2	constant MOUSE_MIDDLE_BUTTON
\ enum GamepadNumber
#0	constant GAMEPAD_PLAYER1
#1	constant GAMEPAD_PLAYER2
#2	constant GAMEPAD_PLAYER3
#3	constant GAMEPAD_PLAYER4
\ enum GamepadButton
#0	constant GAMEPAD_BUTTON_UNKNOWN
#1	constant GAMEPAD_BUTTON_LEFT_FACE_UP
#2	constant GAMEPAD_BUTTON_LEFT_FACE_RIGHT
#3	constant GAMEPAD_BUTTON_LEFT_FACE_DOWN
#4	constant GAMEPAD_BUTTON_LEFT_FACE_LEFT
#5	constant GAMEPAD_BUTTON_RIGHT_FACE_UP
#6	constant GAMEPAD_BUTTON_RIGHT_FACE_RIGHT
#7	constant GAMEPAD_BUTTON_RIGHT_FACE_DOWN
#8	constant GAMEPAD_BUTTON_RIGHT_FACE_LEFT
#9	constant GAMEPAD_BUTTON_LEFT_TRIGGER_1
#10	constant GAMEPAD_BUTTON_LEFT_TRIGGER_2
#11	constant GAMEPAD_BUTTON_RIGHT_TRIGGER_1
#12	constant GAMEPAD_BUTTON_RIGHT_TRIGGER_2
#13	constant GAMEPAD_BUTTON_MIDDLE_LEFT
#14	constant GAMEPAD_BUTTON_MIDDLE
#15	constant GAMEPAD_BUTTON_MIDDLE_RIGHT
#16	constant GAMEPAD_BUTTON_LEFT_THUMB
#17	constant GAMEPAD_BUTTON_RIGHT_THUMB
\ enum GamepadAxis
#0	constant GAMEPAD_AXIS_LEFT_X
#1	constant GAMEPAD_AXIS_LEFT_Y
#2	constant GAMEPAD_AXIS_RIGHT_X
#3	constant GAMEPAD_AXIS_RIGHT_Y
#4	constant GAMEPAD_AXIS_LEFT_TRIGGER
#5	constant GAMEPAD_AXIS_RIGHT_TRIGGER
\ enum ShaderLocationIndex
#0	constant LOC_VERTEX_POSITION
#1	constant LOC_VERTEX_TEXCOORD01
#2	constant LOC_VERTEX_TEXCOORD02
#3	constant LOC_VERTEX_NORMAL
#4	constant LOC_VERTEX_TANGENT
#5	constant LOC_VERTEX_COLOR
#6	constant LOC_MATRIX_MVP
#7	constant LOC_MATRIX_MODEL
#8	constant LOC_MATRIX_VIEW
#9	constant LOC_MATRIX_PROJECTION
#10	constant LOC_VECTOR_VIEW
#11	constant LOC_COLOR_DIFFUSE
#12	constant LOC_COLOR_SPECULAR
#13	constant LOC_COLOR_AMBIENT
#14	constant LOC_MAP_ALBEDO
#15	constant LOC_MAP_METALNESS
#16	constant LOC_MAP_NORMAL
#17	constant LOC_MAP_ROUGHNESS
#18	constant LOC_MAP_OCCLUSION
#19	constant LOC_MAP_EMISSION
#20	constant LOC_MAP_HEIGHT
#21	constant LOC_MAP_CUBEMAP
#22	constant LOC_MAP_IRRADIANCE
#23	constant LOC_MAP_PREFILTER
#24	constant LOC_MAP_BRDF
\ enum ShaderUniformDataType
#0	constant UNIFORM_FLOAT
#1	constant UNIFORM_VEC2
#2	constant UNIFORM_VEC3
#3	constant UNIFORM_VEC4
#4	constant UNIFORM_INT
#5	constant UNIFORM_IVEC2
#6	constant UNIFORM_IVEC3
#7	constant UNIFORM_IVEC4
#8	constant UNIFORM_SAMPLER2D
\ enum MaterialMapType
#0	constant MAP_ALBEDO
#1	constant MAP_METALNESS
#2	constant MAP_NORMAL
#3	constant MAP_ROUGHNESS
#4	constant MAP_OCCLUSION
#5	constant MAP_EMISSION
#6	constant MAP_HEIGHT
#7	constant MAP_CUBEMAP
#8	constant MAP_IRRADIANCE
#9	constant MAP_PREFILTER
#10	constant MAP_BRDF
\ enum PixelFormat
#1	constant UNCOMPRESSED_GRAYSCALE
#2	constant UNCOMPRESSED_GRAY_ALPHA
#3	constant UNCOMPRESSED_R5G6B5
#4	constant UNCOMPRESSED_R8G8B8
#5	constant UNCOMPRESSED_R5G5B5A1
#6	constant UNCOMPRESSED_R4G4B4A4
#7	constant UNCOMPRESSED_R8G8B8A8
#8	constant UNCOMPRESSED_R32
#9	constant UNCOMPRESSED_R32G32B32
#10	constant UNCOMPRESSED_R32G32B32A32
#11	constant COMPRESSED_DXT1_RGB
#12	constant COMPRESSED_DXT1_RGBA
#13	constant COMPRESSED_DXT3_RGBA
#14	constant COMPRESSED_DXT5_RGBA
#15	constant COMPRESSED_ETC1_RGB
#16	constant COMPRESSED_ETC2_RGB
#17	constant COMPRESSED_ETC2_EAC_RGBA
#18	constant COMPRESSED_PVRT_RGB
#19	constant COMPRESSED_PVRT_RGBA
#20	constant COMPRESSED_ASTC_4x4_RGBA
#21	constant COMPRESSED_ASTC_8x8_RGBA
\ enum TextureFilterMode
#0	constant FILTER_POINT
#1	constant FILTER_BILINEAR
#2	constant FILTER_TRILINEAR
#3	constant FILTER_ANISOTROPIC_4X
#4	constant FILTER_ANISOTROPIC_8X
#5	constant FILTER_ANISOTROPIC_16X
\ enum CubemapLayoutType
#0	constant CUBEMAP_AUTO_DETECT
#1	constant CUBEMAP_LINE_VERTICAL
#2	constant CUBEMAP_LINE_HORIZONTAL
#3	constant CUBEMAP_CROSS_THREE_BY_FOUR
#4	constant CUBEMAP_CROSS_FOUR_BY_THREE
#5	constant CUBEMAP_PANORAMA
\ enum TextureWrapMode
#0	constant WRAP_REPEAT
#1	constant WRAP_CLAMP
#2	constant WRAP_MIRROR_REPEAT
#3	constant WRAP_MIRROR_CLAMP
\ enum FontType
#0	constant FONT_DEFAULT
#1	constant FONT_BITMAP
#2	constant FONT_SDF
\ enum BlendMode
#0	constant BLEND_ALPHA
#1	constant BLEND_ADDITIVE
#2	constant BLEND_MULTIPLIED
#3	constant BLEND_ADD_COLORS
#4	constant BLEND_SUBTRACT_COLORS
#5	constant BLEND_CUSTOM
\ enum GestureType
#0	constant GESTURE_NONE
#1	constant GESTURE_TAP
#2	constant GESTURE_DOUBLETAP
#4	constant GESTURE_HOLD
#8	constant GESTURE_DRAG
#16	constant GESTURE_SWIPE_RIGHT
#32	constant GESTURE_SWIPE_LEFT
#64	constant GESTURE_SWIPE_UP
#128	constant GESTURE_SWIPE_DOWN
#256	constant GESTURE_PINCH_IN
#512	constant GESTURE_PINCH_OUT
\ enum CameraMode
#0	constant CAMERA_CUSTOM
#1	constant CAMERA_FREE
#2	constant CAMERA_ORBITAL
#3	constant CAMERA_FIRST_PERSON
#4	constant CAMERA_THIRD_PERSON
\ enum CameraType
#0	constant CAMERA_PERSPECTIVE
#1	constant CAMERA_ORTHOGRAPHIC
\ enum NPatchType
#0	constant NPT_9PATCH
#1	constant NPT_3PATCH_VERTICAL
#2	constant NPT_3PATCH_HORIZONTAL

\ -------===< structs >===--------
\ Vector2
begin-structure Vector2
	drop 0 4 +field Vector2-x
	drop 4 4 +field Vector2-y
drop 8 end-structure
\ Vector3
begin-structure Vector3
	drop 0 4 +field Vector3-x
	drop 4 4 +field Vector3-y
	drop 8 4 +field Vector3-z
drop 12 end-structure
\ Vector4
begin-structure Vector4
	drop 12 4 +field Vector4-w
	drop 0 4 +field Vector4-x
	drop 4 4 +field Vector4-y
	drop 8 4 +field Vector4-z
drop 16 end-structure
\ Matrix
begin-structure Matrix
	drop 0 4 +field Matrix-m0
	drop 60 4 +field Matrix-m15
	drop 16 4 +field Matrix-m1
	drop 32 4 +field Matrix-m2
	drop 48 4 +field Matrix-m3
	drop 4 4 +field Matrix-m4
	drop 20 4 +field Matrix-m5
	drop 36 4 +field Matrix-m6
	drop 52 4 +field Matrix-m7
	drop 8 4 +field Matrix-m8
	drop 24 4 +field Matrix-m9
	drop 40 4 +field Matrix-m10
	drop 56 4 +field Matrix-m11
	drop 12 4 +field Matrix-m12
	drop 28 4 +field Matrix-m13
	drop 44 4 +field Matrix-m14
drop 64 end-structure
\ Color
begin-structure Color
	drop 2 1 +field Color-b
	drop 0 1 +field Color-r
	drop 1 1 +field Color-g
	drop 3 1 +field Color-a
drop 4 end-structure
\ Rectangle
begin-structure Rectangle
	drop 0 4 +field Rectangle-x
	drop 4 4 +field Rectangle-y
	drop 12 4 +field Rectangle-height
	drop 8 4 +field Rectangle-width
drop 16 end-structure
\ Image
begin-structure Image
	drop 0 8 +field Image-data
	drop 16 4 +field Image-mipmaps
	drop 12 4 +field Image-height
	drop 8 4 +field Image-width
	drop 20 4 +field Image-format
drop 24 end-structure
\ Texture2D
begin-structure Texture2D
	drop 0 4 +field Texture2D-id
	drop 12 4 +field Texture2D-mipmaps
	drop 8 4 +field Texture2D-height
	drop 4 4 +field Texture2D-width
	drop 16 4 +field Texture2D-format
drop 20 end-structure
\ RenderTexture2D
begin-structure RenderTexture2D
	drop 0 4 +field RenderTexture2D-id
	drop 4 20 +field RenderTexture2D-texture
	drop 24 20 +field RenderTexture2D-depth
	drop 44 1 +field RenderTexture2D-depthTexture
drop 48 end-structure
\ NPatchInfo
begin-structure NPatchInfo
	drop 16 4 +field NPatchInfo-left
	drop 0 16 +field NPatchInfo-sourceRec
	drop 20 4 +field NPatchInfo-top
	drop 24 4 +field NPatchInfo-right
	drop 32 4 +field NPatchInfo-type
	drop 28 4 +field NPatchInfo-bottom
drop 36 end-structure
\ CharInfo
begin-structure CharInfo
	drop 4 4 +field CharInfo-offsetX
	drop 12 4 +field CharInfo-advanceX
	drop 8 4 +field CharInfo-offsetY
	drop 0 4 +field CharInfo-value
	drop 16 24 +field CharInfo-image
drop 40 end-structure
\ Font
begin-structure Font
	drop 0 4 +field Font-baseSize
	drop 32 8 +field Font-recs
	drop 4 4 +field Font-charsCount
	drop 8 20 +field Font-texture
	drop 40 8 +field Font-chars
drop 48 end-structure
\ Camera3D
begin-structure Camera3D
	drop 36 4 +field Camera3D-fovy
	drop 0 12 +field Camera3D-position
	drop 12 12 +field Camera3D-target
	drop 40 4 +field Camera3D-type
	drop 24 12 +field Camera3D-up
drop 44 end-structure
\ Camera2D
begin-structure Camera2D
	drop 20 4 +field Camera2D-zoom
	drop 8 8 +field Camera2D-target
	drop 0 8 +field Camera2D-offset
	drop 16 4 +field Camera2D-rotation
drop 24 end-structure
\ Mesh
begin-structure Mesh
	drop 64 8 +field Mesh-animVertices
	drop 8 8 +field Mesh-vertices
	drop 0 4 +field Mesh-vertexCount
	drop 40 8 +field Mesh-tangents
	drop 16 8 +field Mesh-texcoords
	drop 48 8 +field Mesh-colors
	drop 104 8 +field Mesh-vboId
	drop 72 8 +field Mesh-animNormals
	drop 32 8 +field Mesh-normals
	drop 88 8 +field Mesh-boneWeights
	drop 56 8 +field Mesh-indices
	drop 24 8 +field Mesh-texcoords2
	drop 4 4 +field Mesh-triangleCount
	drop 80 8 +field Mesh-boneIds
	drop 96 4 +field Mesh-vaoId
drop 112 end-structure
\ Shader
begin-structure Shader
	drop 8 8 +field Shader-locs
	drop 0 4 +field Shader-id
drop 16 end-structure
\ MaterialMap
begin-structure MaterialMap
	drop 20 4 +field MaterialMap-color
	drop 24 4 +field MaterialMap-value
	drop 0 20 +field MaterialMap-texture
drop 28 end-structure
\ Material
begin-structure Material
	drop 0 16 +field Material-shader
	drop 16 8 +field Material-maps
	drop 24 8 +field Material-params
drop 32 end-structure
\ Transform
begin-structure Transform
	drop 0 12 +field Transform-translation
	drop 28 12 +field Transform-scale
	drop 12 16 +field Transform-rotation
drop 40 end-structure
\ BoneInfo
begin-structure BoneInfo
	drop 0 32 +field BoneInfo-name
	drop 32 4 +field BoneInfo-parent
drop 36 end-structure
\ Model
begin-structure Model
	drop 64 4 +field Model-meshCount
	drop 80 4 +field Model-materialCount
	drop 112 8 +field Model-bones
	drop 120 8 +field Model-bindPose
	drop 88 8 +field Model-materials
	drop 96 8 +field Model-meshMaterial
	drop 104 4 +field Model-boneCount
	drop 0 64 +field Model-transform
	drop 72 8 +field Model-meshes
drop 128 end-structure
\ ModelAnimation
begin-structure ModelAnimation
	drop 24 8 +field ModelAnimation-framePoses
	drop 8 8 +field ModelAnimation-bones
	drop 16 4 +field ModelAnimation-frameCount
	drop 0 4 +field ModelAnimation-boneCount
drop 32 end-structure
\ Ray
begin-structure Ray
	drop 0 12 +field Ray-position
	drop 12 12 +field Ray-direction
  drop 24 end-structure

\ RayHitInfo
begin-structure RayHitInfo
	drop 4 4 +field RayHitInfo-distance
	drop 8 12 +field RayHitInfo-position
	drop 0 1 +field RayHitInfo-hit
	drop 20 12 +field RayHitInfo-normal
drop 32 end-structure
\ BoundingBox
begin-structure BoundingBox
	drop 12 12 +field BoundingBox-max
	drop 0 12 +field BoundingBox-min
drop 24 end-structure
\ Wave
begin-structure Wave
	drop 12 4 +field Wave-channels
	drop 16 8 +field Wave-data
	drop 8 4 +field Wave-sampleSize
	drop 4 4 +field Wave-sampleRate
	drop 0 4 +field Wave-sampleCount
drop 24 end-structure
\ AudioStream
begin-structure AudioStream
	drop 8 4 +field AudioStream-channels
	drop 4 4 +field AudioStream-sampleSize
	drop 16 8 +field AudioStream-buffer
	drop 0 4 +field AudioStream-sampleRate
drop 24 end-structure
\ Sound
begin-structure Sound
	drop 8 24 +field Sound-stream
	drop 0 4 +field Sound-sampleCount
drop 32 end-structure
\ Music
begin-structure Music
	drop 24 24 +field Music-stream
	drop 0 4 +field Music-ctxType
	drop 16 1 +field Music-looping
	drop 20 4 +field Music-sampleCount
	drop 8 8 +field Music-ctxData
drop 48 end-structure
\ VrDeviceInfo
begin-structure VrDeviceInfo
	drop 0 4 +field VrDeviceInfo-hResolution
	drop 4 4 +field VrDeviceInfo-vResolution
	drop 20 4 +field VrDeviceInfo-eyeToScreenDistance
	drop 24 4 +field VrDeviceInfo-lensSeparationDistance
	drop 28 4 +field VrDeviceInfo-interpupillaryDistance
	drop 8 4 +field VrDeviceInfo-hScreenSize
	drop 12 4 +field VrDeviceInfo-vScreenSize
	drop 16 4 +field VrDeviceInfo-vScreenCenter
	drop 32 16 +field VrDeviceInfo-lensDistortionValues
	drop 48 16 +field VrDeviceInfo-chromaAbCorrection
drop 64 end-structure

\ ------===< functions >===-------
c-function InitWindow InitWindow n n s -- void	( width height title -- )
c-function WindowShouldClose WindowShouldClose  -- n	( -- )
c-function CloseWindow CloseWindow  -- void	( -- )
c-function IsWindowReady IsWindowReady  -- n	( -- )
c-function IsWindowMinimized IsWindowMinimized  -- n	( -- )
c-function IsWindowMaximized IsWindowMaximized  -- n	( -- )
c-function IsWindowFocused IsWindowFocused  -- n	( -- )
c-function IsWindowResized IsWindowResized  -- n	( -- )
c-function IsWindowHidden IsWindowHidden  -- n	( -- )
c-function IsWindowFullscreen IsWindowFullscreen  -- n	( -- )
c-function ToggleFullscreen ToggleFullscreen  -- void	( -- )
c-function UnhideWindow UnhideWindow  -- void	( -- )
c-function HideWindow HideWindow  -- void	( -- )
c-function DecorateWindow DecorateWindow  -- void	( -- )
c-function UndecorateWindow UndecorateWindow  -- void	( -- )
c-function MaximizeWindow MaximizeWindow  -- void	( -- )
c-function RestoreWindow RestoreWindow  -- void	( -- )
c-function SetWindowIcon SetWindowIcon a{*(Image*)} -- void	( image -- )
c-function SetWindowTitle SetWindowTitle s -- void	( title -- )
c-function SetWindowPosition SetWindowPosition n n -- void	( x y -- )
c-function SetWindowMonitor SetWindowMonitor n -- void	( monitor -- )
c-function SetWindowMinSize SetWindowMinSize n n -- void	( width height -- )
c-function SetWindowSize SetWindowSize n n -- void	( width height -- )
c-function GetWindowHandle GetWindowHandle  -- a	( -- )
c-function GetScreenWidth GetScreenWidth  -- n	( -- )
c-function GetScreenHeight GetScreenHeight  -- n	( -- )
c-function GetMonitorCount GetMonitorCount  -- n	( -- )
c-function GetMonitorWidth GetMonitorWidth n -- n	( monitor -- )
c-function GetMonitorHeight GetMonitorHeight n -- n	( monitor -- )
c-function GetMonitorPhysicalWidth GetMonitorPhysicalWidth n -- n	( monitor -- )
c-function GetMonitorPhysicalHeight GetMonitorPhysicalHeight n -- n	( monitor -- )
c-function GetMonitorRefreshRate GetMonitorRefreshRate n -- n	( monitor -- )

\ Wrapping

\c Vector2 * iGetWindowPosition(Vector2 * p){
\c Vector2 v = GetWindowPosition();
\c *p = v; return p; }
c-function iGetWindowPosition iGetWindowPosition a -- a	( emptyVector2 -- Vector2 )

\c Vector2 * iGetWindowScaleDPI(Vector2 * p){
\c Vector2 v = GetWindowScaleDPI();
\c *p = v; return p; }
c-function iGetWindowScaleDPI iGetWindowScaleDPI a -- a ( emptyVector2 -- Vector2 )

c-function GetMonitorName GetMonitorName n -- s	( monitor -- )
c-function GetClipboardText GetClipboardText  -- s	( -- )
c-function SetClipboardText SetClipboardText s -- void	( text -- )
c-function ShowCursor ShowCursor  -- void	( -- )
c-function HideCursor HideCursor  -- void	( -- )
c-function IsCursorHidden IsCursorHidden  -- n	( -- )
c-function EnableCursor EnableCursor  -- void	( -- )
c-function DisableCursor DisableCursor  -- void	( -- )
c-function IsCursorOnScreen IsCursorOnScreen  -- n	( -- )
c-function ClearBackground ClearBackground a{*(Color*)} -- void	( color -- )
c-function BeginDrawing BeginDrawing  -- void	( -- )
c-function EndDrawing EndDrawing  -- void	( -- )
c-function BeginMode2D BeginMode2D a{*(Camera2D*)} -- void	( camera -- )
c-function EndMode2D EndMode2D  -- void	( -- )
c-function BeginMode3D BeginMode3D a{*(Camera3D*)} -- void	( camera -- )
c-function EndMode3D EndMode3D  -- void	( -- )
c-function BeginTextureMode BeginTextureMode a{*(RenderTexture2D*)} -- void	( target -- )
c-function EndTextureMode EndTextureMode  -- void	( -- )
c-function BeginScissorMode BeginScissorMode n n n n -- void	( x y width height -- )
c-function EndScissorMode EndScissorMode  -- void	( -- )

\ --------------------------------------------------------
\ ----------- Custom Defines -----------------------------

\c Ray* iGetMouseRay(Vector2 v, Camera c, Ray * r){
\c Ray ra = GetMouseRay(v, c);
\c *r = ra; return r; }

c-function iGetMouseRay iGetMouseRay a{*(Vector2*)} a{*(Camera3D*)} a -- a ( mousePosition camera -- Ray )

\c Matrix* iGetCameraMatrix(Camera c, Matrix* m){
\c Matrix ma = GetCameraMatrix(c);
\c *m = ma; return m; }

c-function iGetCameraMatrix iGetCameraMatrix a{*(Camera3D*)} a -- a	( camera matrix -- matrix )

\c Matrix* iGetCameraMatrix2D(Camera2D c, Matrix* m){
\c Matrix ma = GetCameraMatrix2D(c);
\c *m = ma; return m; }

c-function iGetCameraMatrix2D iGetCameraMatrix2D a{*(Camera2D*)} a -- a	( camera2d matrix -- matrix )

\c Vector2* iGetWorldToScreen(Vector3 position, Camera camera, Vector2* v){
\c Vector2 va = GetWorldToScreen(position, camera);
\c *v = va; return v; }

c-function iGetWorldToScreen iGetWorldToScreen a{*(Vector3*)} a{*(Camera3D*)} a -- a ( position camera vector2 -- vector2 )

\c Vector2* iGetWorldToScreenEx(Vector3 pos, Camera cam, int width, int height, Vector2* v){
\c Vector2 va = GetWorldToScreenEx(pos, cam, width, height);
\c *v = va; return v; }

c-function iGetWorldToScreenEx iGetWorldToScreenEx a{*(Vector3*)} a{*(Camera3D*)} n n a -- a	( position camera width height vector2 -- vector2 )

\c Vector2* iGetWorldToScreen2D(Vector2 pos, Camera2D camera, Vector2* v){
\c Vector2 va = GetWorldToScreen2D(pos, camera);
\c *v = va; return v; }

c-function iGetWorldToScreen2D iGetWorldToScreen2D a{*(Vector2*)} a{*(Camera2D*)} a -- a	( position camera vector2 -- vector2 )

\c Vector2* iGetScreenToWorld2D(Vector2 pos, Camera2D camera, Vector2* v){
\c Vector2 va = GetScreenToWorld2D(pos, camera);
\c *v = va; return v; }

c-function iGetScreenToWorld2D iGetScreenToWorld2D a{*(Vector2*)} a{*(Camera2D*)} a -- a	( position camera vector2 -- vector2 )

\ --------------------------------------------------------
\ ------------------End Custom Defines--------------------

c-function SetTargetFPS SetTargetFPS n -- void	( fps -- )
c-function GetFPS GetFPS  -- n	( -- )
c-function GetFrameTime GetFrameTime  -- r	( -- )
c-function GetTime GetTime  -- r	( -- )
c-function SetConfigFlags SetConfigFlags u -- void	( flags -- )
c-function SetTraceLogLevel SetTraceLogLevel n -- void	( logType -- )
c-function SetTraceLogExit SetTraceLogExit n -- void	( logType -- )
c-function SetTraceLogCallback SetTraceLogCallback a -- void	( callback -- )
c-function TraceLog TraceLog n s ... -- void	( logType text <noname> -- )
c-function TakeScreenshot TakeScreenshot s -- void	( fileName -- )
c-function GetRandomValue GetRandomValue n n -- n	( min max -- )
c-function LoadFileData LoadFileData s a -- a	( fileName bytesRead -- )
c-function SaveFileData SaveFileData s a u -- void	( fileName data bytesToWrite -- )
c-function LoadFileText LoadFileText s -- a	( fileName -- )
c-function SaveFileText SaveFileText s a -- void	( fileName text -- )
c-function FileExists FileExists s -- n	( fileName -- )
c-function IsFileExtension IsFileExtension s s -- n	( fileName ext -- )
c-function DirectoryExists DirectoryExists s -- n	( dirPath -- )
c-function GetExtension GetExtension s -- s	( fileName -- )
c-function GetFileName GetFileName s -- s	( filePath -- )
c-function GetFileNameWithoutExt GetFileNameWithoutExt s -- s	( filePath -- )
c-function GetDirectoryPath GetDirectoryPath s -- s	( filePath -- )
c-function GetPrevDirectoryPath GetPrevDirectoryPath s -- s	( dirPath -- )
c-function GetWorkingDirectory GetWorkingDirectory  -- s	( -- )
c-function GetDirectoryFiles GetDirectoryFiles s a -- a	( dirPath count -- )
c-function ClearDirectoryFiles ClearDirectoryFiles  -- void	( -- )
c-function ChangeDirectory ChangeDirectory s -- n	( dir -- )
c-function IsFileDropped IsFileDropped  -- n	( -- )
c-function GetDroppedFiles GetDroppedFiles a -- a	( count -- )
c-function ClearDroppedFiles ClearDroppedFiles  -- void	( -- )
c-function GetFileModTime GetFileModTime s -- n	( fileName -- )
c-function CompressData CompressData a n a -- a	( data dataLength compDataLength -- )
c-function DecompressData DecompressData a n a -- a	( compData compDataLength dataLength -- )
c-function SaveStorageValue SaveStorageValue u n -- void	( position value -- )
c-function LoadStorageValue LoadStorageValue u -- n	( position -- )
c-function OpenURL OpenURL s -- void	( url -- )
c-function IsKeyPressed IsKeyPressed n -- n	( key -- )
c-function IsKeyDown IsKeyDown n -- n	( key -- )
c-function IsKeyReleased IsKeyReleased n -- n	( key -- )
c-function IsKeyUp IsKeyUp n -- n	( key -- )
c-function SetExitKey SetExitKey n -- void	( key -- )
c-function GetKeyPressed GetKeyPressed  -- n	( -- )
c-function IsGamepadAvailable IsGamepadAvailable n -- n	( gamepad -- )
c-function IsGamepadName IsGamepadName n s -- n	( gamepad name -- )
c-function GetGamepadName GetGamepadName n -- s	( gamepad -- )
c-function IsGamepadButtonPressed IsGamepadButtonPressed n n -- n	( gamepad button -- )
c-function IsGamepadButtonDown IsGamepadButtonDown n n -- n	( gamepad button -- )
c-function IsGamepadButtonReleased IsGamepadButtonReleased n n -- n	( gamepad button -- )
c-function IsGamepadButtonUp IsGamepadButtonUp n n -- n	( gamepad button -- )
c-function GetGamepadButtonPressed GetGamepadButtonPressed  -- n	( -- )
c-function GetGamepadAxisCount GetGamepadAxisCount n -- n	( gamepad -- )
c-function GetGamepadAxisMovement GetGamepadAxisMovement n n -- r	( gamepad axis -- )
c-function IsMouseButtonPressed IsMouseButtonPressed n -- n	( button -- )
c-function IsMouseButtonDown IsMouseButtonDown n -- n	( button -- )
c-function IsMouseButtonReleased IsMouseButtonReleased n -- n	( button -- )
c-function IsMouseButtonUp IsMouseButtonUp n -- n	( button -- )
c-function GetMouseX GetMouseX  -- n	( -- )
c-function GetMouseY GetMouseY  -- n	( -- )

\ ---------------- Custom ------------------
\c Vector2* iGetMousePosition(Vector2* v){
\c Vector2 va = GetMousePosition();
\c *v = va; return v; }

c-function iGetMousePosition iGetMousePosition a -- a	( -- vector2 )
\ ------------------------------------------

c-function SetMousePosition SetMousePosition n n -- void	( x y -- )
c-function SetMouseOffset SetMouseOffset n n -- void	( offsetX offsetY -- )
c-function SetMouseScale SetMouseScale r r -- void	( scaleX scaleY -- )
c-function GetMouseWheelMove GetMouseWheelMove  -- n	( -- )
c-function GetTouchX GetTouchX  -- n	( -- )
c-function GetTouchY GetTouchY  -- n	( -- )

\c Vector2* iGetTouchPosition(int index, Vector2* v){
\c Vector2 va = GetTouchPosition(index);
\c *v = va; return v; }

c-function iGetTouchPosition iGetTouchPosition n a -- a	( index vector2 --vector2 )

c-function SetGesturesEnabled SetGesturesEnabled u -- void	( gestureFlags -- )
c-function IsGestureDetected IsGestureDetected n -- n	( gesture -- )
c-function GetGestureDetected GetGestureDetected  -- n	( -- )
c-function GetTouchPointsCount GetTouchPointsCount  -- n	( -- )
c-function GetGestureHoldDuration GetGestureHoldDuration  -- r	( -- )

\c Vector2* iGetGestureDragVector(Vector2* v){
\c Vector2 va = GetGestureDragVector();
\c *v = va; return v; }

c-function iGetGestureDragVector iGetGestureDragVector a -- a	( vector2 -- vector2 )
c-function GetGestureDragAngle GetGestureDragAngle  -- r	( -- )

\c Vector2* iGetGesturePinchVector(Vector2* v){
\c Vector2 va = GetGesturePinchVector();
\c *v = va; return v; }

c-function iGetGesturePinchVector iGetGesturePinchVector a -- a	( vector2  -- vector2 )
c-function GetGesturePinchAngle GetGesturePinchAngle  -- r	( -- )
c-function SetCameraMode SetCameraMode a{*(Camera3D*)} n -- void	( camera mode -- )
c-function UpdateCamera UpdateCamera a -- void	( camera -- )
c-function SetCameraPanControl SetCameraPanControl n -- void	( panKey -- )
c-function SetCameraAltControl SetCameraAltControl n -- void	( altKey -- )
c-function SetCameraSmoothZoomControl SetCameraSmoothZoomControl n -- void	( szKey -- )
c-function SetCameraMoveControls SetCameraMoveControls n n n n n n -- void	( frontKey backKey rightKey leftKey upKey downKey -- )
c-function DrawPixel DrawPixel n n a{*(Color*)} -- void	( posX posY color -- )
c-function DrawPixelV DrawPixelV a{*(Vector2*)} a{*(Color*)} -- void	( position color -- )
c-function DrawLine DrawLine n n n n a{*(Color*)} -- void	( startPosX startPosY endPosX endPosY color -- )
c-function DrawLineV DrawLineV a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( startPos endPos color -- )
c-function DrawLineEx DrawLineEx a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( startPos endPos thick color -- )
c-function DrawLineBezier DrawLineBezier a{*(Vector2*)} a{*(Vector2*)} r a{*(Color*)} -- void	( startPos endPos thick color -- )
c-function DrawLineStrip DrawLineStrip a n a{*(Color*)} -- void	( points numPoints color -- )
c-function DrawCircle DrawCircle n n r a{*(Color*)} -- void	( centerX centerY radius color -- )
c-function DrawCircleSector DrawCircleSector a{*(Vector2*)} r n n n a{*(Color*)} -- void	( center radius startAngle endAngle segments color -- )
c-function DrawCircleSectorLines DrawCircleSectorLines a{*(Vector2*)} r n n n a{*(Color*)} -- void	( center radius startAngle endAngle segments color -- )
c-function DrawCircleGradient DrawCircleGradient n n r a{*(Color*)} a{*(Color*)} -- void	( centerX centerY radius color1 color2 -- )
c-function DrawCircleV DrawCircleV a{*(Vector2*)} r a{*(Color*)} -- void	( center radius color -- )
c-function DrawCircleLines DrawCircleLines n n r a{*(Color*)} -- void	( centerX centerY radius color -- )
c-function DrawEllipse DrawEllipse n n r r a{*(Color*)} -- void	( centerX centerY radiusH radiusV color -- )
c-function DrawEllipseLines DrawEllipseLines n n r r a{*(Color*)} -- void	( centerX centerY radiusH radiusV color -- )
c-function DrawRing DrawRing a{*(Vector2*)} r r n n n a{*(Color*)} -- void	( center innerRadius outerRadius startAngle endAngle segments color -- )
c-function DrawRingLines DrawRingLines a{*(Vector2*)} r r n n n a{*(Color*)} -- void	( center innerRadius outerRadius startAngle endAngle segments color -- )
c-function DrawRectangle DrawRectangle n n n n a{*(Color*)} -- void	( posX posY width height color -- )
c-function DrawRectangleV DrawRectangleV a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( position size color -- )
c-function DrawRectangleRec DrawRectangleRec a{*(Rectangle*)} a{*(Color*)} -- void	( rec color -- )
c-function DrawRectanglePro DrawRectanglePro a{*(Rectangle*)} a{*(Vector2*)} r a{*(Color*)} -- void	( rec origin rotation color -- )
c-function DrawRectangleGradientV DrawRectangleGradientV n n n n a{*(Color*)} a{*(Color*)} -- void	( posX posY width height color1 color2 -- )
c-function DrawRectangleGradientH DrawRectangleGradientH n n n n a{*(Color*)} a{*(Color*)} -- void	( posX posY width height color1 color2 -- )
c-function DrawRectangleGradientEx DrawRectangleGradientEx a{*(Rectangle*)} a{*(Color*)} a{*(Color*)} a{*(Color*)} a{*(Color*)} -- void	( rec col1 col2 col3 col4 -- )
c-function DrawRectangleLines DrawRectangleLines n n n n a{*(Color*)} -- void	( posX posY width height color -- )
c-function DrawRectangleLinesEx DrawRectangleLinesEx a{*(Rectangle*)} n a{*(Color*)} -- void	( rec lineThick color -- )
c-function DrawRectangleRounded DrawRectangleRounded a{*(Rectangle*)} r n a{*(Color*)} -- void	( rec roundness segments color -- )
c-function DrawRectangleRoundedLines DrawRectangleRoundedLines a{*(Rectangle*)} r n n a{*(Color*)} -- void	( rec roundness segments lineThick color -- )
c-function DrawTriangle DrawTriangle a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( v1 v2 v3 color -- )
c-function DrawTriangleLines DrawTriangleLines a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( v1 v2 v3 color -- )
c-function DrawTriangleFan DrawTriangleFan a n a{*(Color*)} -- void	( points numPoints color -- )
c-function DrawTriangleStrip DrawTriangleStrip a n a{*(Color*)} -- void	( points pointsCount color -- )
c-function DrawPoly DrawPoly a{*(Vector2*)} n r r a{*(Color*)} -- void	( center sides radius rotation color -- )
c-function DrawPolyLines DrawPolyLines a{*(Vector2*)} n r r a{*(Color*)} -- void	( center sides radius rotation color -- )
c-function CheckCollisionRecs CheckCollisionRecs a{*(Rectangle*)} a{*(Rectangle*)} -- n	( rec1 rec2 -- )
c-function CheckCollisionCircles CheckCollisionCircles a{*(Vector2*)} r a{*(Vector2*)} r -- n	( center1 radius1 center2 radius2 -- )
c-function CheckCollisionCircleRec CheckCollisionCircleRec a{*(Vector2*)} r a{*(Rectangle*)} -- n	( center radius rec -- )
c-function GetCollisionRec GetCollisionRec a{*(Rectangle*)} a{*(Rectangle*)} -- struct	( rec1 rec2 -- )
c-function CheckCollisionPointRec CheckCollisionPointRec a{*(Vector2*)} a{*(Rectangle*)} -- n	( point rec -- )
c-function CheckCollisionPointCircle CheckCollisionPointCircle a{*(Vector2*)} a{*(Vector2*)} r -- n	( point center radius -- )
c-function CheckCollisionPointTriangle CheckCollisionPointTriangle a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Vector2*)} -- n	( point p1 p2 p3 -- )
c-function LoadImage LoadImage s -- struct	( fileName -- )
c-function LoadImageRaw LoadImageRaw s n n n n -- struct	( fileName width height format headerSize -- )
c-function LoadImageAnim LoadImageAnim s a -- struct	( fileName frames -- )
c-function UnloadImage UnloadImage a{*(Image*)} -- void	( image -- )
c-function ExportImage ExportImage a{*(Image*)} s -- void	( image fileName -- )
c-function ExportImageAsCode ExportImageAsCode a{*(Image*)} s -- void	( image fileName -- )
c-function GenImageColor GenImageColor n n a{*(Color*)} -- struct	( width height color -- )
c-function GenImageGradientV GenImageGradientV n n a{*(Color*)} a{*(Color*)} -- struct	( width height top bottom -- )
c-function GenImageGradientH GenImageGradientH n n a{*(Color*)} a{*(Color*)} -- struct	( width height left right -- )
c-function GenImageGradientRadial GenImageGradientRadial n n r a{*(Color*)} a{*(Color*)} -- struct	( width height density inner outer -- )
c-function GenImageChecked GenImageChecked n n n n a{*(Color*)} a{*(Color*)} -- struct	( width height checksX checksY col1 col2 -- )
c-function GenImageWhiteNoise GenImageWhiteNoise n n r -- struct	( width height factor -- )
c-function GenImagePerlinNoise GenImagePerlinNoise n n n n r -- struct	( width height offsetX offsetY scale -- )
c-function GenImageCellular GenImageCellular n n n -- struct	( width height tileSize -- )
c-function ImageCopy ImageCopy a{*(Image*)} -- struct	( image -- )
c-function ImageFromImage ImageFromImage a{*(Image*)} a{*(Rectangle*)} -- struct	( image rec -- )
c-function ImageText ImageText s n a{*(Color*)} -- struct	( text fontSize color -- )
c-function ImageTextEx ImageTextEx a{*(Font*)} s r r a{*(Color*)} -- struct	( font text fontSize spacing tint -- )
c-function ImageFormat ImageFormat a n -- void	( image newFormat -- )
c-function ImageToPOT ImageToPOT a a{*(Color*)} -- void	( image fill -- )
c-function ImageCrop ImageCrop a a{*(Rectangle*)} -- void	( image crop -- )
c-function ImageAlphaCrop ImageAlphaCrop a r -- void	( image threshold -- )
c-function ImageAlphaClear ImageAlphaClear a a{*(Color*)} r -- void	( image color threshold -- )
c-function ImageAlphaMask ImageAlphaMask a a{*(Image*)} -- void	( image alphaMask -- )
c-function ImageAlphaPremultiply ImageAlphaPremultiply a -- void	( image -- )
c-function ImageResize ImageResize a n n -- void	( image newWidth newHeight -- )
c-function ImageResizeNN ImageResizeNN a n n -- void	( image newWidth newHeight -- )
c-function ImageResizeCanvas ImageResizeCanvas a n n n n a{*(Color*)} -- void	( image newWidth newHeight offsetX offsetY fill -- )
c-function ImageMipmaps ImageMipmaps a -- void	( image -- )
c-function ImageDither ImageDither a n n n n -- void	( image rBpp gBpp bBpp aBpp -- )
c-function ImageFlipVertical ImageFlipVertical a -- void	( image -- )
c-function ImageFlipHorizontal ImageFlipHorizontal a -- void	( image -- )
c-function ImageRotateCW ImageRotateCW a -- void	( image -- )
c-function ImageRotateCCW ImageRotateCCW a -- void	( image -- )
c-function ImageColorTint ImageColorTint a a{*(Color*)} -- void	( image color -- )
c-function ImageColorInvert ImageColorInvert a -- void	( image -- )
c-function ImageColorGrayscale ImageColorGrayscale a -- void	( image -- )
c-function ImageColorContrast ImageColorContrast a r -- void	( image contrast -- )
c-function ImageColorBrightness ImageColorBrightness a n -- void	( image brightness -- )
c-function ImageColorReplace ImageColorReplace a a{*(Color*)} a{*(Color*)} -- void	( image color replace -- )
c-function GetImageData GetImageData a{*(Image*)} -- a	( image -- )
c-function GetImagePalette GetImagePalette a{*(Image*)} n a -- a	( image maxPaletteSize extractCount -- )
c-function GetImageDataNormalized GetImageDataNormalized a{*(Image*)} -- a	( image -- )
c-function GetImageAlphaBorder GetImageAlphaBorder a{*(Image*)} r -- struct	( image threshold -- )
c-function ImageClearBackground ImageClearBackground a a{*(Color*)} -- void	( dst color -- )
c-function ImageDrawPixel ImageDrawPixel a n n a{*(Color*)} -- void	( dst posX posY color -- )
c-function ImageDrawPixelV ImageDrawPixelV a a{*(Vector2*)} a{*(Color*)} -- void	( dst position color -- )
c-function ImageDrawLine ImageDrawLine a n n n n a{*(Color*)} -- void	( dst startPosX startPosY endPosX endPosY color -- )
c-function ImageDrawLineV ImageDrawLineV a a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( dst start end color -- )
c-function ImageDrawCircle ImageDrawCircle a n n n a{*(Color*)} -- void	( dst centerX centerY radius color -- )
c-function ImageDrawCircleV ImageDrawCircleV a a{*(Vector2*)} n a{*(Color*)} -- void	( dst center radius color -- )
c-function ImageDrawRectangle ImageDrawRectangle a n n n n a{*(Color*)} -- void	( dst posX posY width height color -- )
c-function ImageDrawRectangleV ImageDrawRectangleV a a{*(Vector2*)} a{*(Vector2*)} a{*(Color*)} -- void	( dst position size color -- )
c-function ImageDrawRectangleRec ImageDrawRectangleRec a a{*(Rectangle*)} a{*(Color*)} -- void	( dst rec color -- )
c-function ImageDrawRectangleLines ImageDrawRectangleLines a a{*(Rectangle*)} n a{*(Color*)} -- void	( dst rec thick color -- )
c-function ImageDraw ImageDraw a a{*(Image*)} a{*(Rectangle*)} a{*(Rectangle*)} a{*(Color*)} -- void	( dst src srcRec dstRec tint -- )
c-function ImageDrawText ImageDrawText a s n n n a{*(Color*)} -- void	( dst text posX posY fontSize color -- )
c-function ImageDrawTextEx ImageDrawTextEx a a{*(Font*)} s a{*(Vector2*)} r r a{*(Color*)} -- void	( dst font text position fontSize spacing tint -- )
c-function LoadTexture LoadTexture s -- struct	( fileName -- )
c-function LoadTextureFromImage LoadTextureFromImage a{*(Image*)} -- struct	( image -- )
c-function LoadTextureCubemap LoadTextureCubemap a{*(Image*)} n -- n	( image layoutType -- )
c-function LoadRenderTexture LoadRenderTexture n n -- struct	( width height -- )
c-function UnloadTexture UnloadTexture a{*(Texture2D*)} -- void	( texture -- )
c-function UnloadRenderTexture UnloadRenderTexture a{*(RenderTexture2D*)} -- void	( target -- )
c-function UpdateTexture UpdateTexture a{*(Texture2D*)} a -- void	( texture pixels -- )
c-function UpdateTextureRec UpdateTextureRec a{*(Texture2D*)} a{*(Rectangle*)} a -- void	( texture rec pixels -- )
c-function GetTextureData GetTextureData a{*(Texture2D*)} -- struct	( texture -- )
c-function GetScreenData GetScreenData  -- struct	( -- )
c-function GenTextureMipmaps GenTextureMipmaps a -- void	( texture -- )
c-function SetTextureFilter SetTextureFilter a{*(Texture2D*)} n -- void	( texture filterMode -- )
c-function SetTextureWrap SetTextureWrap a{*(Texture2D*)} n -- void	( texture wrapMode -- )
c-function DrawTexture DrawTexture a{*(Texture2D*)} n n a{*(Color*)} -- void	( texture posX posY tint -- )
c-function DrawTextureV DrawTextureV a{*(Texture2D*)} a{*(Vector2*)} a{*(Color*)} -- void	( texture position tint -- )
c-function DrawTextureEx DrawTextureEx a{*(Texture2D*)} a{*(Vector2*)} r r a{*(Color*)} -- void	( texture position rotation scale tint -- )
c-function DrawTextureRec DrawTextureRec a{*(Texture2D*)} a{*(Rectangle*)} a{*(Vector2*)} a{*(Color*)} -- void	( texture sourceRec position tint -- )
c-function DrawTextureQuad DrawTextureQuad a{*(Texture2D*)} a{*(Vector2*)} a{*(Vector2*)} a{*(Rectangle*)} a{*(Color*)} -- void	( texture tiling offset quad tint -- )
c-function DrawTextureTiled DrawTextureTiled a{*(Texture2D*)} a{*(Rectangle*)} a{*(Rectangle*)} a{*(Vector2*)} r r a{*(Color*)} -- void	( texture sourceRec destRec origin rotation scale tint -- )
c-function DrawTexturePro DrawTexturePro a{*(Texture2D*)} a{*(Rectangle*)} a{*(Rectangle*)} a{*(Vector2*)} r a{*(Color*)} -- void	( texture sourceRec destRec origin rotation tint -- )
c-function DrawTextureNPatch DrawTextureNPatch a{*(Texture2D*)} a{*(NPatchInfo*)} a{*(Rectangle*)} a{*(Vector2*)} r a{*(Color*)} -- void	( texture nPatchInfo destRec origin rotation tint -- )
c-function Fade Fade a{*(Color*)} r -- struct	( color alpha -- )
c-function ColorToInt ColorToInt a{*(Color*)} -- n	( color -- )
c-function ColorNormalize ColorNormalize a{*(Color*)} -- struct	( color -- )
c-function ColorFromNormalized ColorFromNormalized a{*(Vector4*)} -- struct	( normalized -- )
c-function ColorToHSV ColorToHSV a{*(Color*)} -- struct	( color -- )
c-function ColorFromHSV ColorFromHSV r r r -- struct	( hue saturation value -- )
c-function ColorAlpha ColorAlpha a{*(Color*)} r -- struct	( color alpha -- )
c-function ColorAlphaBlend ColorAlphaBlend a{*(Color*)} a{*(Color*)} a{*(Color*)} -- struct	( dst src tint -- )
c-function GetColor GetColor n -- struct	( hexValue -- )
c-function GetPixelColor GetPixelColor a n -- struct	( srcPtr format -- )
c-function SetPixelColor SetPixelColor a a{*(Color*)} n -- void	( dstPtr color format -- )
c-function GetPixelDataSize GetPixelDataSize n n n -- n	( width height format -- )
c-function GetFontDefault GetFontDefault  -- struct	( -- )
c-function LoadFont LoadFont s -- struct	( fileName -- )
c-function LoadFontEx LoadFontEx s n a n -- struct	( fileName fontSize fontChars charsCount -- )
c-function LoadFontFromImage LoadFontFromImage a{*(Image*)} a{*(Color*)} n -- struct	( image key firstChar -- )
c-function LoadFontData LoadFontData s n a n n -- a	( fileName fontSize fontChars charsCount type -- )
c-function GenImageFontAtlas GenImageFontAtlas a a n n n n -- struct	( chars recs charsCount fontSize padding packMethod -- )
c-function UnloadFont UnloadFont a{*(Font*)} -- void	( font -- )
c-function DrawFPS DrawFPS n n -- void	( posX posY -- )
c-function DrawText DrawText s n n n a{*(Color*)} -- void	( text posX posY fontSize color -- )
c-function DrawTextEx DrawTextEx a{*(Font*)} s a{*(Vector2*)} r r a{*(Color*)} -- void	( font text position fontSize spacing tint -- )
c-function DrawTextRec DrawTextRec a{*(Font*)} s a{*(Rectangle*)} r r n a{*(Color*)} -- void	( font text rec fontSize spacing wordWrap tint -- )
c-function DrawTextRecEx DrawTextRecEx a{*(Font*)} s a{*(Rectangle*)} r r n a{*(Color*)} n n a{*(Color*)} a{*(Color*)} -- void	( font text rec fontSize spacing wordWrap tint selectStart selectLength selectTint selectBackTint -- )
c-function DrawTextCodepoint DrawTextCodepoint a{*(Font*)} n a{*(Vector2*)} r a{*(Color*)} -- void	( font codepoint position scale tint -- )
c-function MeasureText MeasureText s n -- n	( text fontSize -- )
c-function MeasureTextEx MeasureTextEx a{*(Font*)} s r r -- struct	( font text fontSize spacing -- )
c-function GetGlyphIndex GetGlyphIndex a{*(Font*)} n -- n	( font codepoint -- )
c-function TextCopy TextCopy a s -- n	( dst src -- )
c-function TextIsEqual TextIsEqual s s -- n	( text1 text2 -- )
c-function TextLength TextLength s -- u	( text -- )
c-function TextFormat TextFormat s ... -- s	( text <noname> -- )
c-function TextSubtext TextSubtext s n n -- s	( text position length -- )
c-function TextReplace TextReplace a s s -- a	( text replace by -- )
c-function TextInsert TextInsert s s n -- a	( text insert position -- )
c-function TextJoin TextJoin a n s -- s	( textList count delimiter -- )
c-function TextSplit TextSplit s u a -- a	( text delimiter count -- )
c-function TextAppend TextAppend a s a -- void	( text append position -- )
c-function TextFindIndex TextFindIndex s s -- n	( text find -- )
c-function TextToUpper TextToUpper s -- s	( text -- )
c-function TextToLower TextToLower s -- s	( text -- )
c-function TextToPascal TextToPascal s -- s	( text -- )
c-function TextToInteger TextToInteger s -- n	( text -- )
c-function TextToUtf8 TextToUtf8 a n -- a	( codepoints length -- )
c-function GetCodepoints GetCodepoints s a -- a	( text count -- )
c-function GetCodepointsCount GetCodepointsCount s -- n	( text -- )
c-function GetNextCodepoint GetNextCodepoint s a -- n	( text bytesProcessed -- )
c-function CodepointToUtf8 CodepointToUtf8 n a -- s	( codepoint byteLength -- )
c-function DrawLine3D DrawLine3D a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( startPos endPos color -- )
c-function DrawPoint3D DrawPoint3D a{*(Vector3*)} a{*(Color*)} -- void	( position color -- )
c-function DrawCircle3D DrawCircle3D a{*(Vector3*)} r a{*(Vector3*)} r a{*(Color*)} -- void	( center radius rotationAxis rotationAngle color -- )
c-function DrawTriangle3D DrawTriangle3D a{*(Vector3*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( v1 v2 v3 color -- )
c-function DrawTriangleStrip3D DrawTriangleStrip3D a n a{*(Color*)} -- void	( points pointsCount color -- )
c-function DrawCube DrawCube a{*(Vector3*)} r r r a{*(Color*)} -- void	( position width height length color -- )
c-function DrawCubeV DrawCubeV a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( position size color -- )
c-function DrawCubeWires DrawCubeWires a{*(Vector3*)} r r r a{*(Color*)} -- void	( position width height length color -- )
c-function DrawCubeWiresV DrawCubeWiresV a{*(Vector3*)} a{*(Vector3*)} a{*(Color*)} -- void	( position size color -- )
c-function DrawCubeTexture DrawCubeTexture a{*(Texture2D*)} a{*(Vector3*)} r r r a{*(Color*)} -- void	( texture position width height length color -- )
c-function DrawSphere DrawSphere a{*(Vector3*)} r a{*(Color*)} -- void	( centerPos radius color -- )
c-function DrawSphereEx DrawSphereEx a{*(Vector3*)} r n n a{*(Color*)} -- void	( centerPos radius rings slices color -- )
c-function DrawSphereWires DrawSphereWires a{*(Vector3*)} r n n a{*(Color*)} -- void	( centerPos radius rings slices color -- )
c-function DrawCylinder DrawCylinder a{*(Vector3*)} r r r n a{*(Color*)} -- void	( position radiusTop radiusBottom height slices color -- )
c-function DrawCylinderWires DrawCylinderWires a{*(Vector3*)} r r r n a{*(Color*)} -- void	( position radiusTop radiusBottom height slices color -- )
c-function DrawPlane DrawPlane a{*(Vector3*)} a{*(Vector2*)} a{*(Color*)} -- void	( centerPos size color -- )
c-function DrawRay DrawRay a{*(Ray*)} a{*(Color*)} -- void	( ray color -- )
c-function DrawGrid DrawGrid n r -- void	( slices spacing -- )
c-function DrawGizmo DrawGizmo a{*(Vector3*)} -- void	( position -- )
c-function LoadModel LoadModel s -- struct	( fileName -- )
c-function LoadModelFromMesh LoadModelFromMesh a{*(Mesh*)} -- struct	( mesh -- )
c-function UnloadModel UnloadModel a{*(Model*)} -- void	( model -- )
c-function LoadMeshes LoadMeshes s a -- a	( fileName meshCount -- )
c-function ExportMesh ExportMesh a{*(Mesh*)} s -- void	( mesh fileName -- )
c-function UnloadMesh UnloadMesh a{*(Mesh*)} -- void	( mesh -- )
c-function LoadMaterials LoadMaterials s a -- a	( fileName materialCount -- )
c-function LoadMaterialDefault LoadMaterialDefault  -- struct	( -- )
c-function UnloadMaterial UnloadMaterial a{*(Material*)} -- void	( material -- )
c-function SetMaterialTexture SetMaterialTexture a n a{*(Texture2D*)} -- void	( material mapType texture -- )
c-function SetModelMeshMaterial SetModelMeshMaterial a n n -- void	( model meshId materialId -- )
c-function LoadModelAnimations LoadModelAnimations s a -- a	( fileName animsCount -- )
c-function UpdateModelAnimation UpdateModelAnimation a{*(Model*)} a{*(ModelAnimation*)} n -- void	( model anim frame -- )
c-function UnloadModelAnimation UnloadModelAnimation a{*(ModelAnimation*)} -- void	( anim -- )
c-function IsModelAnimationValid IsModelAnimationValid a{*(Model*)} a{*(ModelAnimation*)} -- n	( model anim -- )
c-function GenMeshPoly GenMeshPoly n r -- struct	( sides radius -- )
c-function GenMeshPlane GenMeshPlane r r n n -- struct	( width length resX resZ -- )
c-function GenMeshCube GenMeshCube r r r -- struct	( width height length -- )
c-function GenMeshSphere GenMeshSphere r n n -- struct	( radius rings slices -- )
c-function GenMeshHemiSphere GenMeshHemiSphere r n n -- struct	( radius rings slices -- )
c-function GenMeshCylinder GenMeshCylinder r r n -- struct	( radius height slices -- )
c-function GenMeshTorus GenMeshTorus r r n n -- struct	( radius size radSeg sides -- )
c-function GenMeshKnot GenMeshKnot r r n n -- struct	( radius size radSeg sides -- )
c-function GenMeshHeightmap GenMeshHeightmap a{*(Image*)} a{*(Vector3*)} -- struct	( heightmap size -- )
c-function GenMeshCubicmap GenMeshCubicmap a{*(Image*)} a{*(Vector3*)} -- struct	( cubicmap cubeSize -- )
c-function MeshBoundingBox MeshBoundingBox a{*(Mesh*)} -- struct	( mesh -- )
c-function MeshTangents MeshTangents a -- void	( mesh -- )
c-function MeshBinormals MeshBinormals a -- void	( mesh -- )
c-function MeshNormalsSmooth MeshNormalsSmooth a -- void	( mesh -- )
c-function DrawModel DrawModel a{*(Model*)} a{*(Vector3*)} r a{*(Color*)} -- void	( model position scale tint -- )
c-function DrawModelEx DrawModelEx a{*(Model*)} a{*(Vector3*)} a{*(Vector3*)} r a{*(Vector3*)} a{*(Color*)} -- void	( model position rotationAxis rotationAngle scale tint -- )
c-function DrawModelWires DrawModelWires a{*(Model*)} a{*(Vector3*)} r a{*(Color*)} -- void	( model position scale tint -- )
c-function DrawModelWiresEx DrawModelWiresEx a{*(Model*)} a{*(Vector3*)} a{*(Vector3*)} r a{*(Vector3*)} a{*(Color*)} -- void	( model position rotationAxis rotationAngle scale tint -- )
c-function DrawBoundingBox DrawBoundingBox a{*(BoundingBox*)} a{*(Color*)} -- void	( box color -- )
c-function DrawBillboard DrawBillboard n a{*(Texture2D*)} a{*(Vector3*)} r a{*(Color*)} -- void	( camera texture center size tint -- )
c-function DrawBillboardRec DrawBillboardRec n a{*(Texture2D*)} a{*(Rectangle*)} a{*(Vector3*)} r a{*(Color*)} -- void	( camera texture sourceRec center size tint -- )
c-function CheckCollisionSpheres CheckCollisionSpheres a{*(Vector3*)} r a{*(Vector3*)} r -- n	( centerA radiusA centerB radiusB -- )
c-function CheckCollisionBoxes CheckCollisionBoxes a{*(BoundingBox*)} a{*(BoundingBox*)} -- n	( box1 box2 -- )
c-function CheckCollisionBoxSphere CheckCollisionBoxSphere a{*(BoundingBox*)} a{*(Vector3*)} r -- n	( box center radius -- )
c-function CheckCollisionRaySphere CheckCollisionRaySphere a{*(Ray*)} a{*(Vector3*)} r -- n	( ray center radius -- )
c-function CheckCollisionRaySphereEx CheckCollisionRaySphereEx a{*(Ray*)} a{*(Vector3*)} r a -- n	( ray center radius collisionPoint -- )
c-function CheckCollisionRayBox CheckCollisionRayBox a{*(Ray*)} a{*(BoundingBox*)} -- n	( ray box -- )
c-function GetCollisionRayModel GetCollisionRayModel a{*(Ray*)} a{*(Model*)} -- struct	( ray model -- )
c-function GetCollisionRayTriangle GetCollisionRayTriangle a{*(Ray*)} a{*(Vector3*)} a{*(Vector3*)} a{*(Vector3*)} -- struct	( ray p1 p2 p3 -- )
c-function GetCollisionRayGround GetCollisionRayGround a{*(Ray*)} r -- struct	( ray groundHeight -- )
c-function LoadShader LoadShader s s -- struct	( vsFileName fsFileName -- )
c-function LoadShaderCode LoadShaderCode s s -- struct	( vsCode fsCode -- )
c-function UnloadShader UnloadShader a{*(Shader*)} -- void	( shader -- )
c-function GetShaderDefault GetShaderDefault  -- struct	( -- )
c-function GetTextureDefault GetTextureDefault  -- struct	( -- )
c-function GetShapesTexture GetShapesTexture  -- struct	( -- )
c-function GetShapesTextureRec GetShapesTextureRec  -- struct	( -- )
c-function SetShapesTexture SetShapesTexture a{*(Texture2D*)} a{*(Rectangle*)} -- void	( texture source -- )
c-function GetShaderLocation GetShaderLocation a{*(Shader*)} s -- n	( shader uniformName -- )
c-function SetShaderValue SetShaderValue a{*(Shader*)} n a n -- void	( shader uniformLoc value uniformType -- )
c-function SetShaderValueV SetShaderValueV a{*(Shader*)} n a n n -- void	( shader uniformLoc value uniformType count -- )
c-function SetShaderValueMatrix SetShaderValueMatrix a{*(Shader*)} n a{*(Matrix*)} -- void	( shader uniformLoc mat -- )
c-function SetShaderValueTexture SetShaderValueTexture a{*(Shader*)} n a{*(Texture2D*)} -- void	( shader uniformLoc texture -- )
c-function SetMatrixProjection SetMatrixProjection a{*(Matrix*)} -- void	( proj -- )
c-function SetMatrixModelview SetMatrixModelview a{*(Matrix*)} -- void	( view -- )
c-function GetMatrixModelview GetMatrixModelview  -- struct	( -- )
c-function GetMatrixProjection GetMatrixProjection  -- struct	( -- )
c-function GenTextureCubemap GenTextureCubemap a{*(Shader*)} a{*(Texture2D*)} n -- struct	( shader map size -- )
c-function GenTextureIrradiance GenTextureIrradiance a{*(Shader*)} a{*(Texture2D*)} n -- struct	( shader cubemap size -- )
c-function GenTexturePrefilter GenTexturePrefilter a{*(Shader*)} a{*(Texture2D*)} n -- struct	( shader cubemap size -- )
c-function GenTextureBRDF GenTextureBRDF a{*(Shader*)} n -- struct	( shader size -- )
c-function BeginShaderMode BeginShaderMode a{*(Shader*)} -- void	( shader -- )
c-function EndShaderMode EndShaderMode  -- void	( -- )
c-function BeginBlendMode BeginBlendMode n -- void	( mode -- )
c-function EndBlendMode EndBlendMode  -- void	( -- )
c-function InitVrSimulator InitVrSimulator  -- void	( -- )
c-function CloseVrSimulator CloseVrSimulator  -- void	( -- )
c-function UpdateVrTracking UpdateVrTracking a -- void	( camera -- )
c-function SetVrConfiguration SetVrConfiguration a{*(VrDeviceInfo*)} a{*(Shader*)} -- void	( info distortion -- )
c-function IsVrSimulatorReady IsVrSimulatorReady  -- n	( -- )
c-function ToggleVrMode ToggleVrMode  -- void	( -- )
c-function BeginVrDrawing BeginVrDrawing  -- void	( -- )
c-function EndVrDrawing EndVrDrawing  -- void	( -- )
c-function InitAudioDevice InitAudioDevice  -- void	( -- )
c-function CloseAudioDevice CloseAudioDevice  -- void	( -- )
c-function IsAudioDeviceReady IsAudioDeviceReady  -- n	( -- )
c-function SetMasterVolume SetMasterVolume r -- void	( volume -- )
c-function LoadWave LoadWave s -- struct	( fileName -- )
c-function LoadSound LoadSound s -- struct	( fileName -- )
c-function LoadSoundFromWave LoadSoundFromWave a{*(Wave*)} -- struct	( wave -- )
c-function UpdateSound UpdateSound a{*(Sound*)} a n -- void	( sound data samplesCount -- )
c-function UnloadWave UnloadWave a{*(Wave*)} -- void	( wave -- )
c-function UnloadSound UnloadSound a{*(Sound*)} -- void	( sound -- )
c-function ExportWave ExportWave a{*(Wave*)} s -- void	( wave fileName -- )
c-function ExportWaveAsCode ExportWaveAsCode a{*(Wave*)} s -- void	( wave fileName -- )
c-function PlaySound PlaySound a{*(Sound*)} -- void	( sound -- )
c-function StopSound StopSound a{*(Sound*)} -- void	( sound -- )
c-function PauseSound PauseSound a{*(Sound*)} -- void	( sound -- )
c-function ResumeSound ResumeSound a{*(Sound*)} -- void	( sound -- )
c-function PlaySoundMulti PlaySoundMulti a{*(Sound*)} -- void	( sound -- )
c-function StopSoundMulti StopSoundMulti  -- void	( -- )
c-function GetSoundsPlaying GetSoundsPlaying  -- n	( -- )
c-function IsSoundPlaying IsSoundPlaying a{*(Sound*)} -- n	( sound -- )
c-function SetSoundVolume SetSoundVolume a{*(Sound*)} r -- void	( sound volume -- )
c-function SetSoundPitch SetSoundPitch a{*(Sound*)} r -- void	( sound pitch -- )
c-function WaveFormat WaveFormat a n n n -- void	( wave sampleRate sampleSize channels -- )
c-function WaveCopy WaveCopy a{*(Wave*)} -- struct	( wave -- )
c-function WaveCrop WaveCrop a n n -- void	( wave initSample finalSample -- )
c-function GetWaveData GetWaveData a{*(Wave*)} -- a	( wave -- )
c-function LoadMusicStream LoadMusicStream s -- struct	( fileName -- )
c-function UnloadMusicStream UnloadMusicStream a{*(Music*)} -- void	( music -- )
c-function PlayMusicStream PlayMusicStream a{*(Music*)} -- void	( music -- )
c-function UpdateMusicStream UpdateMusicStream a{*(Music*)} -- void	( music -- )
c-function StopMusicStream StopMusicStream a{*(Music*)} -- void	( music -- )
c-function PauseMusicStream PauseMusicStream a{*(Music*)} -- void	( music -- )
c-function ResumeMusicStream ResumeMusicStream a{*(Music*)} -- void	( music -- )
c-function IsMusicPlaying IsMusicPlaying a{*(Music*)} -- n	( music -- )
c-function SetMusicVolume SetMusicVolume a{*(Music*)} r -- void	( music volume -- )
c-function SetMusicPitch SetMusicPitch a{*(Music*)} r -- void	( music pitch -- )
c-function GetMusicTimeLength GetMusicTimeLength a{*(Music*)} -- r	( music -- )
c-function GetMusicTimePlayed GetMusicTimePlayed a{*(Music*)} -- r	( music -- )
c-function InitAudioStream InitAudioStream u u u -- struct	( sampleRate sampleSize channels -- )
c-function UpdateAudioStream UpdateAudioStream a{*(AudioStream*)} a n -- void	( stream data samplesCount -- )
c-function CloseAudioStream CloseAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function IsAudioStreamProcessed IsAudioStreamProcessed a{*(AudioStream*)} -- n	( stream -- )
c-function PlayAudioStream PlayAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function PauseAudioStream PauseAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function ResumeAudioStream ResumeAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function IsAudioStreamPlaying IsAudioStreamPlaying a{*(AudioStream*)} -- n	( stream -- )
c-function StopAudioStream StopAudioStream a{*(AudioStream*)} -- void	( stream -- )
c-function SetAudioStreamVolume SetAudioStreamVolume a{*(AudioStream*)} r -- void	( stream volume -- )
c-function SetAudioStreamPitch SetAudioStreamPitch a{*(AudioStream*)} r -- void	( stream pitch -- )
c-function SetAudioStreamBufferSizeDefault SetAudioStreamBufferSizeDefault n -- void	( size -- )

\ ----===< postfix >===-----
end-c-library

: Vector2> ( Vector2 -- f: -- x y )
  dup dup sf@ Vector2-y sf@
  free throw ;

: >Vector2 ( f: -- x y -- Vector2 )
  Vector2 allocate throw
  dup dup sf! Vector2-y sf! ;

: RaylibVector2Call ( xt -- f: -- x y )
  Vector2 allocate throw
  swap execute Vector2> ;

: GetWindowScaleDPI ( -- f: -- x y )
  ['] iGetWindowScaleDPI RaylibVector2Call ;

: GetWindowPosition ( -- f: -- x y )
  ['] iGetWindowPosition RaylibVector2Call ;

: GetMouseRay ( Vector2 Camera3d -- Ray )
  Ray allocate throw
  iGetMouseRay ;
\ Might need memory dalloc

: GetCameraMatrix ( Camera3d -- Matrix )
  Matrix allocate throw
  iGetCameraMatrix ;

: GetCameraMatrix2D ( Camera2d -- Matrix )
  Matrix allocate throw
  iGetCameraMatrix2D ;
