<h1> Not a bad example of localization in Unity, now you can easily translate any TMPText into the language you want, to do this, the LocolizedText script must be hung on the object with the TMPText component and the key must be specified. The text is updated as soon as the button is pressed.
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163430129-28e4cc22-5343-4ccf-ab16-15809122cd0b.png">
<h3> A little more detail:
<h3> 1) Add a localization Manager object to the scene, with the script of the same name
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163575575-7f9861a9-6433-4887-bd35-5f5b56bf50c6.png">
<h3> 2) Add buttons to change the language (as many as you like)
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163576629-f047fa61-6b3d-4e6a-9c45-ed13b70f5745.png">
<h3> Be sure to specify the encoding of the language in the button (attached table):
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163576966-bc1e20ac-2f3f-4ec0-8deb-2db3f6d0d18c.png">
<h3> 3) Now let's add Json containers with key/value. Be sure to place these files in the same place as in the picture;
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163580079-8b08a495-da1e-47a6-beb5-1775bfed0721.png">  
<h3> The files look like this:
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163580358-90a90f29-dbf8-45a8-aad3-dd525c0e5a2d.png">  
<h3> 4) Add LocolizedText to the text and enter the key;
<h3 align="center"><img src="https://user-images.githubusercontent.com/89748954/163583000-3abe57f7-89e7-4ac7-a1f3-76d594dfccd3.png">   
<h3> Done)
