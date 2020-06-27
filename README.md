# TimelineSample

[![youtube](https://img.youtube.com/vi/asrl277oPsI/0.jpg)](http://www.youtube.com/watch?v=asrl277oPsI "Timeline sample.")


手順

GameObjectごとにTimelineをくっつける方法

TimelineSample0のシーン

1 GameObjectを選択、Sphereを選択  
2 Timeline Windowsを選択、Timelineが無いので、create timelineボタンを押す  
3 Timelineを保存  
4 予め作っておいたAnimationをTimelineにDrag & Drop  
Up, Down, Right, Left, Forward, Backの順に並べてみる  
5 再生ボタンを押してアニメーションが順番に再生される事を確認  

6 Cubeを作る  
7 2から5の手順をやる  
8 TimelineにおいたそれぞれのAnimationのSpeed Maltiplierの数値を変えてみる  
9 アニメーションが重なると自動的に補完される  


一つのTimelineで複数のGameObjectをコントロールする方法  

TimelineSample1のシーン  
1 GameObject に Add ComponentでAnimatorをくっつける  
AnimatorのControllerがnoneになっている  
2 Timelineの+ボタンからAnimation Trackを追加  
3 Animation TrackにSphereをDrag and Drop  
4 Down, Up, Left, Right, Back,Forward, をAnimation Trackに  
5 Animation TrackにCubeをDrag and Drop  
6 Up, Down, Right, Left, Forward, BackをAnimation Trackに  

Activate Trackを使う  
7 Activate TrackをTimelineに追加  
8 GameObject CylinderのCylinderRedを作る  
9 CylinderRedをActivate TrackにDrag and Drop  
10 Activate Track上で右クリックでActiveの区間を作る  

Soundを使う  
11 音素材をダウンロード、ここから色々音がダウンロード可能  
https://soundeffect-lab.info/sound/anime/  

12 Audio Trackを追加  
13 空のGame Object を追加 Soundという名前にする  
14 Game Object　Audio Sourceを追加  
15 Audio Trackに SoundのGame ObjectをDrag and Drop  
16 Audio Trackに右クリックをして、Audioを追加  

Control Track  
17 GameObject CubeBlue, CubeRedを作る  
18 Timelineの+ボタンを押して、Control Trackを作る  
19 Control Track上で、右クリックをして、Activeの区間を追加、追加するときにGameObjectかPrefabを選択できる  

Signal Track  
20 Timelineの+ボタンを押して、Signal Trackを作る  
21 Signalを受けるゲームオブジェクト、Capsuleを作る  
22 Capsuleに Signal Receiverコンポーネントを追加  
23 Signal Receiverを作ると、Signalを指定する所があるのでそこからSignalを作る、Capsuleとする  
24 Signal Trackに CapsuleをDrag & Drop  
25 UIのボタンを押した時の関数のように、Compornentを作り、シグナルから呼ばれるPubicな関数を作る  
26 Signal ReceiverのAdd Reactionを押すと25で作った関数を登録できる、  
27 Signal Trackで追加したSignal Emitterでcapsuleのシグナルを選択をする  


